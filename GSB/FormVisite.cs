using lesClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GSB
{
    public partial class FormVisite : FrmBase
    {
        public FormVisite()
        {
            InitializeComponent();
        }

        private void FormVisite_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            initialiserDgv(dataGridView1);
            initialiserDgv(dataGridView2);
            remplirDgv();
        }

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Consultation des visites";
            this.label16.Text = "Sélectionner la visite pour afficher le détail";
            this.label2.Text = "Practicien";
            this.label4.Text = "Rue";
            this.label6.Text = "Téléphone";
            this.label8.Text = "Email";            
            this.label10.Text = "Type praticien";            
            this.label12.Text = "Spécialité";
            this.label14.Text = "Motif";
            this.label18.Text = "Bilan de la visite";
            this.label19.Text = "Echantillions fournis";
            this.label20.Text = "Médicaments présentés";

            dataGridView2.ColumnHeadersVisible = false;
        }

        #region procédures

        private void remplirDgv()
        {
            dataGridView1.Rows.Clear();
            foreach (Visite v in Globale.mesVisites)
            {
                dataGridView1.Rows.Add(v.Id, v.DateEtHeure, v.DateEtHeure, v.LePraticien.Ville);
            }
        }

        private void initialiserDgv(DataGridView dgv)
        {
            #region paramétrage au niveau du composant

            // accessibilité du composant
            dgv.Enabled = true;

            // permissions
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowDrop = false;
            dgv.AllowUserToOrderColumns = false;

            //  bordures extérieures
            dgv.BorderStyle = BorderStyle.FixedSingle;

            // Bordure au niveau des cellules
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Couleur de fond 
            dgv.BackgroundColor = Color.White;

            // Couleur de texte  
            dgv.ForeColor = Color.Black;

            // Mode de sélection : FullRowSelect, CellSelect ...
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // sélection multiple 
            dgv.MultiSelect = false;

            // Police de caractère des cellules
            dgv.DefaultCellStyle.Font = new Font("Garamond", 10);

            #endregion

            #region paramètrage des colonnes

            // Entête aux niveaux des colonnes 
            dgv.ColumnHeadersVisible = true;

            // Ajustement de la taille des colonnes : fill pour par un ajustement proportionnel à la largeur totale 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Définition du style au niveau des entêtes de colonne    
            dgv.EnableHeadersVisualStyles = false;
            DataGridViewCellStyle style = dgv.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.LightGray;
            style.ForeColor = Color.Black;
            // par défaut si on sélectionne une cellule la couleur de fond de l'entête passe au bleu
            style.SelectionBackColor = Color.LightGray;
            // on peut définir l'alignement pour toute la ligne d'entête
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            style.Font = new Font("Garamond", 10, FontStyle.Bold);


            #endregion

            #region paramétrage des lignes

            // Hauteur des lignes
            dgv.RowTemplate.Height = 25;

            // Entête sur les lignes 
            dgv.RowHeadersVisible = false;

            // masquer la ligne sélectionnée en lui attribuant la même couleur de fond que les autres lignes
            dgv.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dgv.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            // Couleur alternative appliquée une ligne sur deux
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 238, 238, 238);

            #endregion

            // Hauteur
        }
        
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer la première ligne sélectionnée
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                // Récupérer les valeurs des cellules de la ligne sélectionnée
                int cellValue1 = (int)dataGridView1.SelectedRows[0].Cells[0].Value; // Valeur de la première colonne

                // Utiliser les valeurs récupérées pour effectuer les traitements nécessaires
                foreach (Visite v in Globale.mesVisites)
                {
                    if (cellValue1 == v.Id)
                    {
                        label3.Text = v.LePraticien.NomPrenom;
                        label5.Text = v.LePraticien.Rue;
                        label7.Text = v.LePraticien.Telephone;
                        label9.Text = v.LePraticien.Email;
                        label11.Text = v.LePraticien.Type.Libelle;
                        label13.Text = v.LePraticien.Specialite.Libelle;
                        label15.Text = v.LeMotif.Libelle;
                        label21.Text = v.Bilan;
                        if (v.Bilan != "NULL")
                        {
                            
                            dataGridView2.Rows.Add(v.Bilan, v.LeMotif.Libelle);
                        }
                    }
                }
            }
        }

        #endregion
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB {
    public partial class FrmPraticienListe : FrmBase {
        public FrmPraticienListe() {
            InitializeComponent();
        }

        private void FrmPraticienListe_Load(object sender, EventArgs e) 
        {
            parametrerComposant();
            initialiserDgv(dataGridView1);
            remplirDgv();
        }

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Liste des praticiens";
        }

        private void remplirDgv()
        {
            dataGridView1.Rows.Clear();
            foreach (lesClasses.Praticien p in Globale.mesPraticiens)
            {
                bool date = false;
                foreach (lesClasses.Visite v in Globale.mesVisites)
                {
                    if (v.LePraticien.Id == p.Id)
                    {
                        dataGridView1.Rows.Add(p.NomPrenom, p.Telephone, p.Email, p.Rue, v.DateEtHeure);
                        date = true;
                    }
                }     
                if(date == false)
                    dataGridView1.Rows.Add(p.NomPrenom, p.Telephone, p.Email, p.Rue, "Aucune visite");
            }
            dataGridView1.Sort(dataGridView1.Columns["nomPrenom"], ListSortDirection.Ascending);

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // On vérifie si la dernière cellule de la ligne a la valeur cherchée
                if (row.Cells["date"].Value.ToString() == "Aucune visite" || DateTime.Now.AddMonths(-6) > Convert.ToDateTime(row.Cells["date"].Value))
                {
                    row.DefaultCellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void initialiserDgv(DataGridView dgv)
        {
            #region paramétrage au niveau du composant

            // accessibilité du composant
            dgv.Enabled = false;

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
    }
}

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

namespace GSB
{
    public partial class FrmVisiteListe : FrmBase
    {
        public FrmVisiteListe()
        {
            InitializeComponent();
        }

        private void FrmVisiteListe_Load(object sender, EventArgs e)
        {
            parametrerComposant();
            initialiserDgv(dgvLesVisites);
            remplirDgv();
        }

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Consultation des visites";
            this.lblVisite.Text = "Sélectionner la visite pour afficher le détail";
        }

        #region procédures

        private void remplirDgv()
        {
            
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

            // largeur du composant à 320
            dgv.Width = 333;

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

            // Nombre de colonnes
            dgv.ColumnCount = 3;

            // Entête aux niveaux des colonnes 
            dgv.ColumnHeadersVisible = true;

            // Ajustement de la taille des colonnes : fill pour par un ajustement proportionnel à la largeur totale 
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Paramétrage de la première colonne  : largeur, titre, alignement, tri 
            dgv.Columns[0].Width = 80;
            dgv.Columns[0].HeaderText = "Référence";
            dgv.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Paramétrage de la seconde colonne
            dgv.Columns[1].Width = 150;
            dgv.Columns[1].HeaderText = "Désignation";
            dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;

            // Paramétrage de la seconde colonne
            dgv.Columns[2].Width = 100;
            dgv.Columns[2].HeaderText = "Quantité";
            dgv.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns[1].SortMode = DataGridViewColumnSortMode.NotSortable;


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

        #endregion
    }
}

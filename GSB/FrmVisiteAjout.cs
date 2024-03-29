﻿using lesClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSB {
    public partial class FrmVisiteAjout : FrmBase {
        public FrmVisiteAjout() {
            InitializeComponent();
        }

        private void FrmVisiteAjout_Load(object sender, EventArgs e) {
            parametrerComposant();
            initialiserDgv(dataGridView1);
            remplirDgv();
            remplirGroup();
        }

        private void parametrerComposant() {
            this.lblTitre.Text = "Enregistrer un nouveau rendez-vous";
            this.label1.Text = "Nouveau rendez-vous";
            this.label2.Text = "Praticien";
            this.label3.Text = "Motif";
            this.label4.Text = "Date et heure";
        }

        private void remplirDgv()
        {
            dataGridView1.Rows.Clear();
            foreach (Visite v in Globale.mesVisites)
            {
                dataGridView1.Rows.Add(v.DateEtHeure, v.DateEtHeure, v.LePraticien.Ville, v.LePraticien.NomPrenom);
            }
        }

        private void remplirGroup()
        {
            comboBox1.DataSource = Globale.mesPraticiens;

            comboBox2.DataSource = Globale.lesMotifs;
        }

        #region procédures

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
        
        private void button1_Click(object sender, EventArgs e)
        {
            string nomPrenom = comboBox1.SelectedItem.ToString();
            Praticien p = Globale.mesPraticiens.Find(x => string.Compare(x.NomPrenom, nomPrenom, true) == 0);
            string motif = comboBox2.SelectedItem.ToString();
            Motif m = Globale.lesMotifs.Find(x => x.Libelle == motif);
            string message = "Ajout d'un rendez-vous";
            DateTime d = dateTimePicker1.Value;
            Passerelle.ajouterRendezVous(p.Id, m.Id, d, out message);
        }

        #endregion
    }
}

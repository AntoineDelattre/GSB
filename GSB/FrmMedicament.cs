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
    public partial class FrmMedicament : FrmBase
    {
        public FrmMedicament()
        {
            InitializeComponent();
        }

        private void FrmMedicament_Load(object sender, EventArgs e)
        {
            parametrerComposant();
        }

        private void parametrerComposant()
        {
            this.lblTitre.Text = "Fiche médicament";

            this.label1.Text = "Médicament";
            txtMedicament.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtMedicament.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach (lesClasses.Medicament unMedicament in Globale.lesMedicaments)
                source.Add(unMedicament.Nom);
            txtMedicament.AutoCompleteCustomSource = source;

            this.label2.Text = "Famille";
            this.label3.Text = "";

            this.label4.Text = "Composition";
            this.label5.Text = "";

            this.label6.Text = "Effet";
            this.label7.Text = "";

            this.label8.Text = "Contre-indication";
            this.label9.Text = "";
        }
        
        private void txtMedicament_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                verifMedicament();
            }
        }

        private void verifMedicament()
        {
            lesClasses.Medicament leMedicament = Globale.lesMedicaments.Find(x => x.Nom == txtMedicament.Text);
            if (leMedicament == null)
            {
                MessageBox.Show("Le médicament n'existe pas");
                label3.Text = "";
                label5.Text = "";
                label7.Text = "";
                label9.Text = "";
            }
            else
            {
                label3.Text = leMedicament.LaFamille.Libelle;
                label5.Text = leMedicament.Composition;
                label7.Text = leMedicament.Effets;
                label9.Text = leMedicament.ContreIndication;
            }

        }
    }
}

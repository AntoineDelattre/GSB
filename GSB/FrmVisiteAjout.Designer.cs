namespace GSB {
    partial class FrmVisiteAjout {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.motifBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.praticienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visiteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rueDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialiteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomPrenomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbVisiteDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unpraticien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.motifBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(936, 64);
            // 
            // motifBindingSource
            // 
            this.motifBindingSource.DataSource = typeof(lesClasses.Motif);
            // 
            // praticienBindingSource
            // 
            this.praticienBindingSource.DataSource = typeof(lesClasses.Praticien);
            // 
            // visiteBindingSource
            // 
            this.visiteBindingSource.DataSource = typeof(lesClasses.Visite);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            // 
            // prenomDataGridViewTextBoxColumn1
            // 
            this.prenomDataGridViewTextBoxColumn1.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn1.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn1.Name = "prenomDataGridViewTextBoxColumn1";
            // 
            // rueDataGridViewTextBoxColumn1
            // 
            this.rueDataGridViewTextBoxColumn1.DataPropertyName = "Rue";
            this.rueDataGridViewTextBoxColumn1.HeaderText = "Rue";
            this.rueDataGridViewTextBoxColumn1.Name = "rueDataGridViewTextBoxColumn1";
            // 
            // codePostalDataGridViewTextBoxColumn1
            // 
            this.codePostalDataGridViewTextBoxColumn1.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn1.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn1.Name = "codePostalDataGridViewTextBoxColumn1";
            // 
            // villeDataGridViewTextBoxColumn1
            // 
            this.villeDataGridViewTextBoxColumn1.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn1.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn1.Name = "villeDataGridViewTextBoxColumn1";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // telephoneDataGridViewTextBoxColumn1
            // 
            this.telephoneDataGridViewTextBoxColumn1.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn1.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn1.Name = "telephoneDataGridViewTextBoxColumn1";
            // 
            // typeDataGridViewTextBoxColumn1
            // 
            this.typeDataGridViewTextBoxColumn1.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn1.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn1.Name = "typeDataGridViewTextBoxColumn1";
            // 
            // specialiteDataGridViewTextBoxColumn1
            // 
            this.specialiteDataGridViewTextBoxColumn1.DataPropertyName = "Specialite";
            this.specialiteDataGridViewTextBoxColumn1.HeaderText = "Specialite";
            this.specialiteDataGridViewTextBoxColumn1.Name = "specialiteDataGridViewTextBoxColumn1";
            // 
            // nomPrenomDataGridViewTextBoxColumn1
            // 
            this.nomPrenomDataGridViewTextBoxColumn1.DataPropertyName = "NomPrenom";
            this.nomPrenomDataGridViewTextBoxColumn1.HeaderText = "NomPrenom";
            this.nomPrenomDataGridViewTextBoxColumn1.Name = "nomPrenomDataGridViewTextBoxColumn1";
            this.nomPrenomDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nbVisiteDataGridViewTextBoxColumn1
            // 
            this.nbVisiteDataGridViewTextBoxColumn1.DataPropertyName = "NbVisite";
            this.nbVisiteDataGridViewTextBoxColumn1.HeaderText = "NbVisite";
            this.nbVisiteDataGridViewTextBoxColumn1.Name = "nbVisiteDataGridViewTextBoxColumn1";
            this.nbVisiteDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(596, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 404);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(3, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 372);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.motifBindingSource;
            this.comboBox2.DisplayMember = "Libelle";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(146, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.praticienBindingSource;
            this.comboBox1.DisplayMember = "NomPrenom";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(146, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yy hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 169);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2023, 3, 24, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2023, 3, 24, 11, 45, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.date,
            this.heure,
            this.ville,
            this.unpraticien});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(596, 404);
            this.dataGridView1.TabIndex = 16;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "D";
            dataGridViewCellStyle3.NullValue = null;
            this.date.DefaultCellStyle = dataGridViewCellStyle3;
            this.date.HeaderText = "programmée le";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // heure
            // 
            this.heure.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Format = "t";
            dataGridViewCellStyle4.NullValue = null;
            this.heure.DefaultCellStyle = dataGridViewCellStyle4;
            this.heure.HeaderText = "à";
            this.heure.Name = "heure";
            this.heure.ReadOnly = true;
            // 
            // ville
            // 
            this.ville.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ville.HeaderText = "sur";
            this.ville.Name = "ville";
            this.ville.ReadOnly = true;
            // 
            // unpraticien
            // 
            this.unpraticien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unpraticien.HeaderText = "chez";
            this.unpraticien.Name = "unpraticien";
            this.unpraticien.ReadOnly = true;
            // 
            // FrmVisiteAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 534);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVisiteAjout";
            this.Text = "FrmVisiteAjout";
            this.Load += new System.EventHandler(this.FrmVisiteAjout_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.motifBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.praticienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visiteBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource praticienBindingSource;
        private System.Windows.Forms.BindingSource visiteBindingSource;
        private System.Windows.Forms.BindingSource motifBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rueDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialiteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomPrenomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbVisiteDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn heure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn unpraticien;
    }
}
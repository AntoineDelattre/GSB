namespace GSB
{
    partial class FrmVisiteListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblVisite = new System.Windows.Forms.Label();
            this.dgvLesVisites = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesVisites)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.Size = new System.Drawing.Size(595, 64);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvLesVisites);
            this.panel2.Controls.Add(this.lblVisite);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 361);
            this.panel2.TabIndex = 13;
            // 
            // lblVisite
            // 
            this.lblVisite.AutoSize = true;
            this.lblVisite.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblVisite.Location = new System.Drawing.Point(0, 0);
            this.lblVisite.Name = "lblVisite";
            this.lblVisite.Size = new System.Drawing.Size(24, 13);
            this.lblVisite.TabIndex = 14;
            this.lblVisite.Text = "titre";
            // 
            // dgvLesVisites
            // 
            this.dgvLesVisites.AllowUserToAddRows = false;
            this.dgvLesVisites.AllowUserToDeleteRows = false;
            this.dgvLesVisites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLesVisites.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLesVisites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLesVisites.Location = new System.Drawing.Point(0, 13);
            this.dgvLesVisites.Name = "dgvLesVisites";
            this.dgvLesVisites.ReadOnly = true;
            this.dgvLesVisites.Size = new System.Drawing.Size(245, 348);
            this.dgvLesVisites.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "programmée le";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "à";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "sur";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // FrmVisiteListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 491);
            this.Controls.Add(this.panel2);
            this.Name = "FrmVisiteListe";
            this.Text = "FrmVisiteListe";
            this.Load += new System.EventHandler(this.FrmVisiteListe_Load);
            this.Controls.SetChildIndex(this.lblTitre, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLesVisites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblVisite;
        private System.Windows.Forms.DataGridView dgvLesVisites;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
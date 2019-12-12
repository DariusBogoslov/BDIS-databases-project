namespace BDISApp
{
    partial class BDISAppDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDISAppDashboard));
            this.tileAdaugarePacient = new MetroFramework.Controls.MetroTile();
            this.modifyPatientTile = new MetroFramework.Controls.MetroTile();
            this.searchPatientTile = new MetroFramework.Controls.MetroTile();
            this.deletePatientTile = new MetroFramework.Controls.MetroTile();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tileAdaugarePacient
            // 
            this.tileAdaugarePacient.ActiveControl = null;
            this.tileAdaugarePacient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileAdaugarePacient.Location = new System.Drawing.Point(242, 107);
            this.tileAdaugarePacient.Name = "tileAdaugarePacient";
            this.tileAdaugarePacient.Size = new System.Drawing.Size(127, 83);
            this.tileAdaugarePacient.TabIndex = 0;
            this.tileAdaugarePacient.Text = "Adaugare pacient";
            this.tileAdaugarePacient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAdaugarePacient.UseSelectable = true;
            this.tileAdaugarePacient.Click += new System.EventHandler(this.tileAdaugarePacient_Click);
            // 
            // modifyPatientTile
            // 
            this.modifyPatientTile.ActiveControl = null;
            this.modifyPatientTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyPatientTile.Location = new System.Drawing.Point(391, 107);
            this.modifyPatientTile.Name = "modifyPatientTile";
            this.modifyPatientTile.Size = new System.Drawing.Size(127, 83);
            this.modifyPatientTile.TabIndex = 1;
            this.modifyPatientTile.Text = "Modificare date";
            this.modifyPatientTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.modifyPatientTile.UseSelectable = true;
            this.modifyPatientTile.Click += new System.EventHandler(this.modifyPatientTile_Click);
            // 
            // searchPatientTile
            // 
            this.searchPatientTile.ActiveControl = null;
            this.searchPatientTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchPatientTile.Location = new System.Drawing.Point(391, 210);
            this.searchPatientTile.Name = "searchPatientTile";
            this.searchPatientTile.Size = new System.Drawing.Size(127, 83);
            this.searchPatientTile.TabIndex = 3;
            this.searchPatientTile.Text = "Cautare pacient";
            this.searchPatientTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchPatientTile.UseSelectable = true;
            this.searchPatientTile.Click += new System.EventHandler(this.searchPatientTile_Click);
            // 
            // deletePatientTile
            // 
            this.deletePatientTile.ActiveControl = null;
            this.deletePatientTile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletePatientTile.Location = new System.Drawing.Point(242, 210);
            this.deletePatientTile.Name = "deletePatientTile";
            this.deletePatientTile.Size = new System.Drawing.Size(127, 83);
            this.deletePatientTile.TabIndex = 2;
            this.deletePatientTile.Text = "Stergere pacient";
            this.deletePatientTile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletePatientTile.UseSelectable = true;
            this.deletePatientTile.Click += new System.EventHandler(this.deletePatientTile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageSize = 40;
            this.btnLogout.Location = new System.Drawing.Point(478, 370);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(72, 70);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // BDISAppDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.searchPatientTile);
            this.Controls.Add(this.deletePatientTile);
            this.Controls.Add(this.modifyPatientTile);
            this.Controls.Add(this.tileAdaugarePacient);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BDISAppDashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BSIDAppDashboard_FormClosed);
            this.Load += new System.EventHandler(this.BSIDAppDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileAdaugarePacient;
        private MetroFramework.Controls.MetroTile modifyPatientTile;
        private MetroFramework.Controls.MetroTile searchPatientTile;
        private MetroFramework.Controls.MetroTile deletePatientTile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink btnLogout;
    }
}
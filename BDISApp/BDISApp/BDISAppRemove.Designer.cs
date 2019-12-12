namespace BDISApp
{
    partial class BDISAppRemove
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDISAppRemove));
            this.bDISAppDataSet = new BDISApp.BDISAppDataSet();
            this.bDISAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientSearchGrid = new MetroFramework.Controls.MetroGrid();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDISAppDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnCautarePacient = new MetroFramework.Controls.MetroButton();
            this.patientSearchBox = new MetroFramework.Controls.MetroTextBox();
            this.backButton = new MetroFramework.Controls.MetroLink();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDeletePatient = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.bDISAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDISAppDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDISAppDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDISAppDataSet
            // 
            this.bDISAppDataSet.DataSetName = "BDISAppDataSet";
            this.bDISAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bDISAppDataSetBindingSource
            // 
            this.bDISAppDataSetBindingSource.DataSource = this.bDISAppDataSet;
            this.bDISAppDataSetBindingSource.Position = 0;
            // 
            // patientSearchGrid
            // 
            this.patientSearchGrid.AllowUserToAddRows = false;
            this.patientSearchGrid.AllowUserToResizeRows = false;
            this.patientSearchGrid.AutoGenerateColumns = false;
            this.patientSearchGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.patientSearchGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientSearchGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.patientSearchGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientSearchGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.patientSearchGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientSearchGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeDataGridViewTextBoxColumn,
            this.prenumeDataGridViewTextBoxColumn,
            this.cNPDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.datanasteriiDataGridViewTextBoxColumn,
            this.varstaDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.patientSearchGrid.DataSource = this.patientsBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientSearchGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.patientSearchGrid.EnableHeadersVisualStyles = false;
            this.patientSearchGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.patientSearchGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.patientSearchGrid.Location = new System.Drawing.Point(17, 103);
            this.patientSearchGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientSearchGrid.Name = "patientSearchGrid";
            this.patientSearchGrid.ReadOnly = true;
            this.patientSearchGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientSearchGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.patientSearchGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.patientSearchGrid.RowTemplate.Height = 24;
            this.patientSearchGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientSearchGrid.Size = new System.Drawing.Size(495, 194);
            this.patientSearchGrid.TabIndex = 0;
            this.patientSearchGrid.Visible = false;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenumeDataGridViewTextBoxColumn
            // 
            this.prenumeDataGridViewTextBoxColumn.DataPropertyName = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.HeaderText = "Prenume";
            this.prenumeDataGridViewTextBoxColumn.Name = "prenumeDataGridViewTextBoxColumn";
            this.prenumeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cNPDataGridViewTextBoxColumn
            // 
            this.cNPDataGridViewTextBoxColumn.DataPropertyName = "CNP";
            this.cNPDataGridViewTextBoxColumn.HeaderText = "CNP";
            this.cNPDataGridViewTextBoxColumn.Name = "cNPDataGridViewTextBoxColumn";
            this.cNPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datanasteriiDataGridViewTextBoxColumn
            // 
            this.datanasteriiDataGridViewTextBoxColumn.DataPropertyName = "Data_nasterii";
            this.datanasteriiDataGridViewTextBoxColumn.HeaderText = "Data nasterii";
            this.datanasteriiDataGridViewTextBoxColumn.Name = "datanasteriiDataGridViewTextBoxColumn";
            this.datanasteriiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // varstaDataGridViewTextBoxColumn
            // 
            this.varstaDataGridViewTextBoxColumn.DataPropertyName = "Varsta";
            this.varstaDataGridViewTextBoxColumn.HeaderText = "Varsta";
            this.varstaDataGridViewTextBoxColumn.Name = "varstaDataGridViewTextBoxColumn";
            this.varstaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientsBindingSource1
            // 
            this.patientsBindingSource1.DataSource = typeof(BDISApp.Patients);
            // 
            // bDISAppDataSetBindingSource1
            // 
            this.bDISAppDataSetBindingSource1.DataSource = this.bDISAppDataSet;
            this.bDISAppDataSetBindingSource1.Position = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 65);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "CNP pacient:";
            // 
            // btnCautarePacient
            // 
            this.btnCautarePacient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCautarePacient.Location = new System.Drawing.Point(309, 65);
            this.btnCautarePacient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCautarePacient.Name = "btnCautarePacient";
            this.btnCautarePacient.Size = new System.Drawing.Size(78, 19);
            this.btnCautarePacient.TabIndex = 3;
            this.btnCautarePacient.Text = "Cautare";
            this.btnCautarePacient.UseSelectable = true;
            this.btnCautarePacient.Click += new System.EventHandler(this.btnCautarePacient_Click);
            // 
            // patientSearchBox
            // 
            // 
            // 
            // 
            this.patientSearchBox.CustomButton.Image = null;
            this.patientSearchBox.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.patientSearchBox.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientSearchBox.CustomButton.Name = "";
            this.patientSearchBox.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.patientSearchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.patientSearchBox.CustomButton.TabIndex = 1;
            this.patientSearchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.patientSearchBox.CustomButton.UseSelectable = true;
            this.patientSearchBox.CustomButton.Visible = false;
            this.patientSearchBox.Lines = new string[0];
            this.patientSearchBox.Location = new System.Drawing.Point(102, 65);
            this.patientSearchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.patientSearchBox.MaxLength = 32767;
            this.patientSearchBox.Name = "patientSearchBox";
            this.patientSearchBox.PasswordChar = '\0';
            this.patientSearchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.patientSearchBox.SelectedText = "";
            this.patientSearchBox.SelectionLength = 0;
            this.patientSearchBox.SelectionStart = 0;
            this.patientSearchBox.ShortcutsEnabled = true;
            this.patientSearchBox.Size = new System.Drawing.Size(185, 19);
            this.patientSearchBox.TabIndex = 4;
            this.patientSearchBox.UseSelectable = true;
            this.patientSearchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.patientSearchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(18, 303);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 5;
            this.backButton.UseSelectable = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataSource = typeof(BDISApp.Patients);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePatient.Location = new System.Drawing.Point(407, 320);
            this.btnDeletePatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(105, 27);
            this.btnDeletePatient.TabIndex = 6;
            this.btnDeletePatient.Text = "Stergere pacient";
            this.btnDeletePatient.UseSelectable = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // BDISAppRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.patientSearchBox);
            this.Controls.Add(this.btnCautarePacient);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.patientSearchGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BDISAppRemove";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Stergere pacient";
            this.Load += new System.EventHandler(this.BDISAppRemove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDISAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDISAppDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDISAppDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bDISAppDataSetBindingSource;
        private BDISAppDataSet bDISAppDataSet;
        private MetroFramework.Controls.MetroGrid patientSearchGrid;
        private System.Windows.Forms.BindingSource bDISAppDataSetBindingSource1;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnCautarePacient;
        private MetroFramework.Controls.MetroTextBox patientSearchBox;
        private MetroFramework.Controls.MetroLink backButton;
        private MetroFramework.Controls.MetroButton btnDeletePatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}
namespace BDISApp
{
    partial class BDISAppSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDISAppSearch));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.searchPacient = new MetroFramework.Controls.MetroTextBox();
            this.btnSearchPatient = new MetroFramework.Controls.MetroButton();
            this.backButton = new MetroFramework.Controls.MetroLink();
            this.patientSearchGrid = new MetroFramework.Controls.MetroGrid();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanasteriiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varstaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.patientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.patientSearchGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(190, 51);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CNP pacient:";
            // 
            // searchPacient
            // 
            // 
            // 
            // 
            this.searchPacient.CustomButton.Image = null;
            this.searchPacient.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.searchPacient.CustomButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchPacient.CustomButton.Name = "";
            this.searchPacient.CustomButton.Size = new System.Drawing.Size(13, 14);
            this.searchPacient.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchPacient.CustomButton.TabIndex = 1;
            this.searchPacient.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchPacient.CustomButton.UseSelectable = true;
            this.searchPacient.CustomButton.Visible = false;
            this.searchPacient.Lines = new string[0];
            this.searchPacient.Location = new System.Drawing.Point(317, 51);
            this.searchPacient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchPacient.MaxLength = 32767;
            this.searchPacient.Name = "searchPacient";
            this.searchPacient.PasswordChar = '\0';
            this.searchPacient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchPacient.SelectedText = "";
            this.searchPacient.SelectionLength = 0;
            this.searchPacient.SelectionStart = 0;
            this.searchPacient.ShortcutsEnabled = true;
            this.searchPacient.Size = new System.Drawing.Size(262, 19);
            this.searchPacient.TabIndex = 1;
            this.searchPacient.UseSelectable = true;
            this.searchPacient.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchPacient.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchPatient.Location = new System.Drawing.Point(638, 51);
            this.btnSearchPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(98, 19);
            this.btnSearchPatient.TabIndex = 3;
            this.btnSearchPatient.Text = "Cautare";
            this.btnSearchPatient.UseSelectable = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backButton.BackgroundImage")));
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Location = new System.Drawing.Point(18, 340);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 6;
            this.backButton.UseSelectable = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // patientSearchGrid
            // 
            this.patientSearchGrid.AllowUserToAddRows = false;
            this.patientSearchGrid.AllowUserToDeleteRows = false;
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
            this.patientSearchGrid.Location = new System.Drawing.Point(32, 104);
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
            this.patientSearchGrid.Size = new System.Drawing.Size(333, 194);
            this.patientSearchGrid.TabIndex = 7;
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
            this.datanasteriiDataGridViewTextBoxColumn.HeaderText = "Data_nasterii";
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
            // reportViewer
            // 
            this.reportViewer.ActiveViewIndex = -1;
            this.reportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer.DisplayStatusBar = false;
            this.reportViewer.DisplayToolbar = false;
            this.reportViewer.Location = new System.Drawing.Point(412, 104);
            this.reportViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.Size = new System.Drawing.Size(571, 273);
            this.reportViewer.TabIndex = 8;
            this.reportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.reportViewer.Visible = false;
            // 
            // patientsBindingSource
            // 
            this.patientsBindingSource.DataSource = typeof(BDISApp.Patients);
            // 
            // BDISAppSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 410);
            this.Controls.Add(this.reportViewer);
            this.Controls.Add(this.patientSearchGrid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.btnSearchPatient);
            this.Controls.Add(this.searchPacient);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BDISAppSearch";
            this.Padding = new System.Windows.Forms.Padding(15, 49, 15, 16);
            this.Text = "Cautare pacient";
            this.Load += new System.EventHandler(this.BDISAppSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientSearchGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox searchPacient;
        private System.Windows.Forms.BindingSource patientsBindingSource;
        private MetroFramework.Controls.MetroButton btnSearchPatient;
        private MetroFramework.Controls.MetroLink backButton;
        private MetroFramework.Controls.MetroGrid patientSearchGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanasteriiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn varstaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource patientsBindingSource1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportViewer;
    }
}
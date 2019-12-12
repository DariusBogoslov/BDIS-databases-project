using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BDISApp
{
    public partial class BDISAppSearch : MetroFramework.Forms.MetroForm
    {
        static BDISAppSearch _instance;

        public static BDISAppSearch Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BDISAppSearch();
                return _instance;
            }
        }

        public BDISAppSearch()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.FlatAppearance.BorderSize = 0;
            this.Hide();
            searchPacient.Text = "";
            this.patientSearchGrid.Visible = false;
            this.reportViewer.Visible = false;
            BDISAppDashboard.Instance.Show();
        }

        private void BDISAppSearch_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
                using (BDISPatients db = new BDISPatients())
                {
                    var CNP = long.Parse(searchPacient.Text);
                    var data = from patient in db.Patients
                               where patient.CNP == CNP
                               select patient;

                    var user_UID = "";
                    foreach(var item in data)
                    {
                        user_UID = item.UID.ToString();
                    }

                populateReport(user_UID);

                    if (data.Count() != 0)
                    {
                        this.patientSearchGrid.Visible = true;
                        this.reportViewer.Visible = true;
                        patientSearchGrid.DataSource = data.ToList();                      
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pacientul nu este in baza de date", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
        }

        private void populateReport(string UID)
        {
            PatientReport report = new PatientReport();

            using (BDISAppMedicalConditions db = new BDISAppMedicalConditions())
            {
                var data = from patient in db.MedicalConditions
                           where patient.Patient_UID == UID
                           select patient;
                report.SetDataSource(data.ToList());
                reportViewer.ReportSource = report;
                reportViewer.RefreshReport();
            }

        }
    }
}

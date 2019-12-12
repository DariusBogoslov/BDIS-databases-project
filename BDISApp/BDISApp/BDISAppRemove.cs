using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDISApp
{
    public partial class BDISAppRemove : MetroFramework.Forms.MetroForm
    {
        static BDISAppRemove _instance;
        string user_UID = "";

        public static BDISAppRemove Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BDISAppRemove();
                return _instance;
            }
        }


        public BDISAppRemove()
        {
            InitializeComponent();
        }

        private void btnCautarePacient_Click(object sender, EventArgs e)
        {
            
            using (BDISPatients db = new BDISPatients())
            {
                var CNP = long.Parse(patientSearchBox.Text);
                var data = from patient in db.Patients
                           where patient.CNP == CNP
                           select patient;
                if(data.Count() != 0)
                {
                    this.patientSearchGrid.Visible = true;
                    patientSearchGrid.DataSource = data.ToList();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pacientul nu este in baza de date", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }

        private void BDISAppRemove_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.FlatAppearance.BorderSize = 0;
            this.Hide();
            patientSearchBox.Text = "";
            patientSearchGrid.Hide();
            BDISAppDashboard.Instance.Show();
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            var CNP = long.Parse(patientSearchBox.Text);
            

            using (BDISPatients db = new BDISPatients())
            {
                var patientToRemove = db.Patients.SingleOrDefault(x => x.CNP == CNP);
                user_UID = patientToRemove.UID.ToString();
                if (patientToRemove != null)
                {
                    db.Patients.Remove(patientToRemove);
                    db.SaveChanges();
                    patientSearchGrid.Hide();
                    MetroFramework.MetroMessageBox.Show(this, "Pacientul a fost sters.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                 
            }
            using (BDISAppMedicalConditions db = new BDISAppMedicalConditions())
            {
                db.MedicalConditions.RemoveRange(db.MedicalConditions.Where(x => x.Patient_UID == user_UID));
                db.SaveChanges();
            }
            
        }
    }
}

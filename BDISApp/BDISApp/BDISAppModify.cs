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
    public partial class BDISAppModify : MetroFramework.Forms.MetroForm
    {
        static BDISAppModify _instance;
        private Guid patientUID;

        public static BDISAppModify Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BDISAppModify();
                return _instance;
            }
        }

        private void ResetText()
        {
            modTxtNume.Text = "";
            modTxtPrenume.Text = "";
            modTxtEmail.Text = "";
            modTxtAdresa.Text = "";
            modTxtAge.Text = "";
            modTxtAfec.Text = "";
            searchPacient.Text = "";
        }
        public BDISAppModify()
        {
            InitializeComponent();
        }

        private void BDISAppModify_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.FlatAppearance.BorderSize = 0;
            this.Hide();
            BDISAppModify.Instance.ResetText();
            BDISAppDashboard.Instance.Show();
        }

        private void btnSearchPatient_Click(object sender, EventArgs e)
        {
            using (BDISPatients db = new BDISPatients())
            {
                var CNP = long.Parse(searchPacient.Text);
                var data = from patient in db.Patients
                           where patient.CNP == CNP
                           select patient;
                if (data.Count() != 0)
                {
                    foreach (var item in data)
                    {
                        modTxtNume.Text = item.Nume;
                        modTxtPrenume.Text = item.Prenume;
                        modTxtEmail.Text = item.Email;
                        modTxtAdresa.Text = item.Adresa;
                        modDateTime.Value = item.Data_nasterii;
                        modTxtAge.Text = item.Varsta.ToString();
                        patientUID = item.UID;
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Pacientul nu este in baza de date", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            using (BDISPatients db = new BDISPatients())
            {
                var CNP = long.Parse(searchPacient.Text);
                var originalUser = db.Patients.FirstOrDefault(item => item.CNP == CNP);
                var updatedUser = originalUser;
                if (originalUser != null)
                {
                    updatedUser.Nume = modTxtNume.Text;
                    updatedUser.Prenume = modTxtPrenume.Text;
                    updatedUser.Email = modTxtEmail.Text;
                    updatedUser.Adresa = modTxtAdresa.Text;
                    updatedUser.Data_nasterii = modDateTime.Value;
                    updatedUser.Varsta = byte.Parse(modTxtAge.Text);
                    db.Entry(originalUser).CurrentValues.SetValues(updatedUser);
                    if(db.SaveChanges() > 0)
                    {

                        MetroFramework.MetroMessageBox.Show(this, "Datele pacientului au fost actualizate cu succes.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Datele pacientului nu au fost actualizate.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void modAddAfec_Click(object sender, EventArgs e)
        {
            using (BDISAppMedicalConditions db = new BDISAppMedicalConditions())
            {
                MedicalConditions mC = new MedicalConditions();
                mC.Afectiune = modTxtAfec.Text;
                mC.Data = afecDate.Value;
                mC.Patient_UID = patientUID.ToString();
                mC.Entry_UID = Guid.NewGuid();
                db.MedicalConditions.Add(mC);
                if (db.SaveChanges() > 0)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Inregistrarea a fost adaugata.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Inregistrarea nu s-a putut adauga in baza de date.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

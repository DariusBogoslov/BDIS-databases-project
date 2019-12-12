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
    public partial class BDISAppAdd : MetroFramework.Forms.MetroForm
    {
        static BDISAppAdd _instance;

        public static BDISAppAdd Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BDISAppAdd();
                return _instance;
            }
        }
        public BDISAppAdd()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            backButton.FlatAppearance.BorderSize = 0;
            this.Hide();
            BDISAppAdd.Instance.ResetText();
            BDISAppDashboard.Instance.Show();
        }

        private void ResetText()
        {
            addTxtNume.Text = "";
            addTxtPrenume.Text = "";
            addTxtEmail.Text = "";
            addTxtAdresa.Text = "";
            addTxtCNP.Text = "";
            addTxtAge.Text = "";
        }

        private void adaugarePacient_Click(object sender, EventArgs e)
        {
            try
            {
                using (BDISPatients db = new BDISPatients())
                {
                    Patients patient = new Patients();
                    patient.Nume = addTxtNume.Text;
                    patient.Prenume = addTxtPrenume.Text;
                    patient.CNP = long.Parse(addTxtCNP.Text);
                    patient.Adresa = addTxtAdresa.Text;
                    patient.Data_nasterii = addDateTime.Value;
                    patient.Varsta = byte.Parse(addTxtAge.Text);
                    patient.Email = addTxtEmail.Text;
                    patient.UID = Guid.NewGuid();
                    db.Patients.Add(patient);
                    if (db.SaveChanges() > 0)
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Pacientul a fost adaugat cu succes.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Pacientul nu a putut fi adaugat in baza de date.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

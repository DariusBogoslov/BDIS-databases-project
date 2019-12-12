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
    public partial class BDISAppLogin : MetroFramework.Forms.MetroForm 
    {
        static BDISAppLogin _instance;

        public static BDISAppLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BDISAppLogin();
                return _instance;
            }
        }
        public BDISAppLogin()
        {

            InitializeComponent();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BDISAppLogin_Load(object sender, EventArgs e)
        {
            _instance = this;
            txtUsername.Focus();
        }

        public void FieldReset()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Va rugam sa introduceti un utilizator.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroFramework.MetroMessageBox.Show(this, "Va rugam sa introduceti o parola.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPassword.Focus();
                return;
            }

            try
            {
                using (BDISAppEntities db = new BDISAppEntities())
                {
                    var query = from u in db.Users
                                where u.username == txtUsername.Text && u.password == txtPassword.Text
                                select u;
                    if (query.SingleOrDefault() != null)
                    {
                        this.Hide();
                        BDISAppDashboard app = new BDISAppDashboard();
                        app.ShowDialog();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Utilizatorul sau parola nu sunt corecte.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_KeyPress(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}

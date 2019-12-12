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
    public partial class BDISAppDashboard : MetroFramework.Forms.MetroForm
    {
        static BDISAppDashboard _instance;
        bool logOut;

        public static BDISAppDashboard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new BDISAppDashboard();
                return _instance;
            }
        }

        public BDISAppDashboard()
        {
            InitializeComponent();
        }

        private void BSIDAppDashboard_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {

        }

        private void BSIDAppDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (!logOut)
               // Application.Restart();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnLogout.FlatAppearance.BorderSize = 0;
            logOut = true;
            this.Hide();
            BDISAppLogin.Instance.FieldReset();
            BDISAppLogin.Instance.Show();
        }
        

        private void tileAdaugarePacient_Click(object sender, EventArgs e)
        {
            this.Hide();
            BDISAppAdd.Instance.Show();
        }

        private void modifyPatientTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            BDISAppModify.Instance.Show();
        }

        private void deletePatientTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            BDISAppRemove.Instance.Show();
        }

        private void searchPatientTile_Click(object sender, EventArgs e)
        {
            this.Hide();
            BDISAppSearch.Instance.Show();
        }
    }
}

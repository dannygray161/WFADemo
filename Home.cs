using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFADemo
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome " + UserInfo.firstname + " " + UserInfo.lastname;
        }
    }
}

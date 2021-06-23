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

namespace WFADemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(cn);
            sqlConnection.Open();

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True";

            if (tbPassword.Text != string.Empty && tbUsername.Text != string.Empty)
            {
                var conn = new SqlConnection(cn);
                conn.Open();
                var cmd = new SqlCommand("select * from tbl_Users where Username='" + tbUsername.Text + "' and Password='" + tbPassword.Text + "'", conn);
                var dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No account found, please try again.");
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields!!");
            }
        }
    }
}

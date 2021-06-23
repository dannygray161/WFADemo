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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True";
            SqlConnection connection = new SqlConnection(cn);
            connection.Open();

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(cn);
            sqlConnection.Open();
            if (tbCreatePassword.Text != string.Empty && tbConfirmPassword.Text != string.Empty && tbCreateUserName.Text != string.Empty && tbFirstName.Text != string.Empty && tbLastName.Text != string.Empty  )
            {
                if (tbCreatePassword.Text == tbConfirmPassword.Text)
                {
                    var cmd = new SqlCommand("select * from tbl_Users where Username='" + tbCreateUserName.Text + "'", sqlConnection);
                    var dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Taken try another. ");
                    }
                    else
                    {
                        dr.Close();
                        var cmd1 = new SqlCommand("insert into tbl_Users values(@username,@password,@firstname,@lastname,@email)", sqlConnection);
                        cmd1.Parameters.AddWithValue("username", tbCreateUserName.Text);
                        cmd1.Parameters.AddWithValue("password", tbCreatePassword.Text);
                        cmd1.Parameters.AddWithValue("firstname", tbFirstName.Text);
                        cmd1.Parameters.AddWithValue("lastname", tbLastName.Text);
                        cmd1.Parameters.AddWithValue("email", tbEmail.Text);
                        cmd1.ExecuteNonQuery();
                        MessageBox.Show("Account Created Successfully, Please Log in. ", "Acknowledge", MessageBoxButtons.OK);
                        UserInfo.firstname = tbFirstName.Text;
                        UserInfo.lastname = tbLastName.Text;
                        this.Hide();
                        Login login = new Login();
                        login.ShowDialog();


                    }
                }
                else
                {
                    MessageBox.Show("Please make sure both passwords match!!", "Error", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields!", "Error", MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

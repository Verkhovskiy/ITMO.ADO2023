using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO2023.FinalTask
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        static string domain = (AppDomain.CurrentDomain.BaseDirectory).ToString();
        public static string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= " + domain + "AdventureWorksLT2012.mdf;" + "Integrated Security=True;Connect Timeout=15;";

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.parent = this;
            registration.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connect);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM SalesLT.Customer WHERE EmailAddress=@user AND PasswordSalt=@pass", con);
                cmd.Parameters.Add("@user", SqlDbType.VarChar);
                cmd.Parameters["@user"].Value = EmailTxtBox.Text;
                cmd.Parameters.Add("@pass", SqlDbType.VarChar);
                cmd.Parameters["@pass"].Value = PasswordTxtBox.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    con.Open();
                    cmd = new SqlCommand("SELECT CustomerID FROM SalesLT.Customer WHERE EmailAddress=@user", con);
                    cmd.Parameters.Add("@user", SqlDbType.VarChar);
                    cmd.Parameters["@user"].Value = EmailTxtBox.Text;
                    int id = (int)cmd.ExecuteScalar();
                    con.Close();
                    if (id == 1)
                    {
                        AdminPage adminPage = new AdminPage();
                        adminPage.parent = this;
                        adminPage.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserPage userPage = new UserPage();
                        userPage.parent = this;
                        userPage.userId = id;
                        userPage.UpdateUserData();
                        userPage.Show();
                        this.Hide();
                    }
                }
                else MessageBox.Show("Something went wrong");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginsPasswords grid = new LoginsPasswords();
            grid.Show();
        }
    }
}

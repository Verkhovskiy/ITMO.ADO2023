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

namespace ITMO.ADO2023.FinalTask
{
    public partial class RegistrationForm : Form
    {
        public LoginForm parent;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!parent.Visible)
            {
                parent.Close();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.connect);
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO SalesLT.Customer (Title,FirstName,MiddleName,LastName,Suffix,CompanyName,EmailAddress,Phone,PasswordSalt,PasswordHash) " +
                    "VALUES(@title,@firstName,@middleName,@lastName,@suffix,@companyName,@email,@phone,@password,@passwordHash)", con);
                cmd.Parameters.Add("@title", SqlDbType.NVarChar);
                cmd.Parameters["@title"].Value = TitleBox.Text;
                cmd.Parameters.Add("@firstName", SqlDbType.NVarChar);
                cmd.Parameters["@firstName"].Value = FirstNameTxtBox.Text;
                cmd.Parameters.Add("@middleName", SqlDbType.NVarChar);
                cmd.Parameters["@middleName"].Value = MiddleNameTxtBox.Text;
                cmd.Parameters.Add("@lastName", SqlDbType.NVarChar);
                cmd.Parameters["@lastName"].Value = LastNameTxtBox.Text;
                cmd.Parameters.Add("@suffix", SqlDbType.NVarChar);
                cmd.Parameters["@suffix"].Value = SuffixTxtBox.Text;
                cmd.Parameters.Add("@companyName", SqlDbType.NVarChar);
                cmd.Parameters["@companyName"].Value = CompanyNameTxtBox.Text;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar);
                cmd.Parameters["@email"].Value = EmailTxtBox.Text;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar);
                cmd.Parameters["@phone"].Value = PhoneTxtBox.Text;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar);
                cmd.Parameters["@password"].Value = PasswordTxtBox.Text;
                cmd.Parameters.Add("@passwordHash", SqlDbType.NVarChar);
                cmd.Parameters["@passwordHash"].Value = "sample_hash";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Successfully Registred");

                parent.Show();
                this.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }
        }
    }
}

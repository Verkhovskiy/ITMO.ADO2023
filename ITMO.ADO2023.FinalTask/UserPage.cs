using ITMO.ADO2023.FinalTask.AdventureWorksLT2012DataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ITMO.ADO2023.FinalTask
{

    public partial class UserPage : Form
    {
        string title;
        string firstName;
        string middleName;
        string lastName;
        string suffix;
        string companyName;
        string phone;
        string email;
        string password;

        public LoginForm parent;
        public int userId;
        public UserPage()
        {
            InitializeComponent();
        }

        public void UpdateUserData()
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.connect);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM SalesLT.Customer WHERE CustomerID=@id";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = userId;

                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                title = reader["Title"].ToString();
                firstName = reader["FirstName"].ToString();
                middleName = reader["MiddleName"].ToString();
                lastName = reader["LastName"].ToString();
                suffix = reader["Suffix"].ToString();
                companyName = reader["CompanyName"].ToString();
                phone = reader["Phone"].ToString();
                email = reader["EmailAddress"].ToString();
                password = reader["PasswordSalt"].ToString();
                con.Close();

                this.UpdateLabels();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }
        }

        public void UpdateLabels()
        {
            GreetLabel.Text = "Hello, " + title + firstName + " " + lastName + "!";
            UserDataLabel.Text = "Your info:" + "\nCompany Name: " + companyName + "\nPhone: " + phone;
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void UserPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!parent.Visible)
            {
                parent.Close();
            }
        }

        private void ChangeInfoBtn_Click(object sender, EventArgs e)
        {
            ChangeInfoForm changeInfoPage = new ChangeInfoForm();
            changeInfoPage.Email = email;
            changeInfoPage.Password = password;
            changeInfoPage.Title = title;
            changeInfoPage.FirstName = firstName;
            changeInfoPage.MiddleName = middleName;
            changeInfoPage.LastName = lastName;
            changeInfoPage.Suffix = suffix;
            changeInfoPage.CompanyName = companyName;
            changeInfoPage.Phone = phone;
            if (changeInfoPage.ShowDialog() != DialogResult.OK) return;
            email = changeInfoPage.Email;
            password = changeInfoPage.Password;
            title = changeInfoPage.Title;
            firstName = changeInfoPage.FirstName;
            middleName = changeInfoPage.MiddleName;
            lastName = changeInfoPage.LastName;
            suffix = changeInfoPage.Suffix;
            companyName = changeInfoPage.CompanyName;
            phone = changeInfoPage.Phone;

            this.UpdateLabels();
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.connect);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "UPDATE SalesLT.Customer SET " +
                    "[EmailAddress]=@email," +
                    "[Title]=@title," +
                    "[FirstName]=@firstName," +
                    "[MiddleName]=@middleName," +
                    "[LastName]=@lastName," +
                    "[Suffix]=@suffix," +
                    "[CompanyName]=@companyName," +
                    "[Phone]=@phone," +
                    "[PasswordSalt]=@password" +
                    " WHERE CustomerID=@id";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = userId;
                cmd.Parameters.Add("@title", SqlDbType.NVarChar);
                cmd.Parameters["@title"].Value = title;
                cmd.Parameters.Add("@firstName", SqlDbType.NVarChar);
                cmd.Parameters["@firstName"].Value = firstName;
                cmd.Parameters.Add("@middleName", SqlDbType.NVarChar);
                cmd.Parameters["@middleName"].Value = middleName;
                cmd.Parameters.Add("@lastName", SqlDbType.NVarChar);
                cmd.Parameters["@lastName"].Value = lastName;
                cmd.Parameters.Add("@suffix", SqlDbType.NVarChar);
                cmd.Parameters["@suffix"].Value = suffix;
                cmd.Parameters.Add("@companyName", SqlDbType.NVarChar);
                cmd.Parameters["@companyName"].Value = companyName;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar);
                cmd.Parameters["@email"].Value = email;
                cmd.Parameters.Add("@phone", SqlDbType.NVarChar);
                cmd.Parameters["@phone"].Value = phone;
                cmd.Parameters.Add("@password", SqlDbType.NVarChar);
                cmd.Parameters["@password"].Value = password;
                cmd.ExecuteNonQuery();

                MessageBox.Show("Successfully Updated");
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.connect);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT * FROM SalesLT.SalesOrderHeader WHERE CustomerID=@id";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = userId;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    ordersView.DataSource = dt;
                }
                con.Close();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }
        }

        private void addOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(LoginForm.connect);
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO SalesLT.SalesOrderHeader([RevisionNumber],[OrderDate],[DueDate],[ShipDate],[Status],[OnlineOrderFlag],[CustomerID],[ShipMethod],[SubTotal],[TaxAmt],[Freight]) " +
                    "VALUES(@revisionNumber,@orderDate,@dueDate,@shipDate,@status,@onlineOrderFlag,@id,@shipMethod,@subTotal,@taxAmt,@freight)";
                cmd.Parameters.Add("@id", SqlDbType.Int);
                cmd.Parameters["@id"].Value = userId;
                cmd.Parameters.Add("@revisionNumber", SqlDbType.TinyInt);
                cmd.Parameters["@revisionNumber"].Value = 2;
                cmd.Parameters.Add("@orderDate", SqlDbType.DateTime);
                cmd.Parameters["@orderDate"].Value = "2008-06-01 00:00:00.000";
                cmd.Parameters.Add("@dueDate", SqlDbType.DateTime);
                cmd.Parameters["@dueDate"].Value = "2008-06-13 00:00:00.000";
                cmd.Parameters.Add("@shipDate", SqlDbType.DateTime);
                cmd.Parameters["@shipDate"].Value = "2008-06-08 00:00:00.000";
                cmd.Parameters.Add("@status", SqlDbType.TinyInt);
                cmd.Parameters["@status"].Value = 5;
                cmd.Parameters.Add("@onlineOrderFlag", SqlDbType.Int);
                cmd.Parameters["@onlineOrderFlag"].Value = 0;
                cmd.Parameters.Add("@shipMethod", SqlDbType.NVarChar);
                cmd.Parameters["@shipMethod"].Value = "CARGO TRANSPORT 5";
                cmd.Parameters.Add("@subTotal", SqlDbType.Int);
                cmd.Parameters["@subTotal"].Value = 0;
                cmd.Parameters.Add("@taxAmt", SqlDbType.Int);
                cmd.Parameters["@taxAmt"].Value = 0;
                cmd.Parameters.Add("@freight", SqlDbType.Int);
                cmd.Parameters["@freight"].Value = 0;
                cmd.ExecuteNonQuery();
                LoadData();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.ToString());
            }
        }
    }
}

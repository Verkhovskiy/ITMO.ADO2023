using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADO2023.FinalTask
{
    public partial class ChangeInfoForm : Form
    {
        public string Email
        {
            get { return EmailTxtBox.Text; }
            set { EmailTxtBox.Text = value; }
        }
        public string Password
        {
            get { return PasswordTxtBox.Text; }
            set { PasswordTxtBox.Text = value; }
        }
        public string Title
        {
            get { return TitleBox.Text; }
            set { TitleBox.Text = value; }
        }
        public string FirstName
        {
            get { return FirstNameTxtBox.Text; }
            set { FirstNameTxtBox.Text = value; }
        }
        public string MiddleName
        {
            get { return MiddleNameTxtBox.Text; }
            set { MiddleNameTxtBox.Text = value; }
        }
        public string LastName
        {
            get { return LastNameTxtBox.Text; }
            set { LastNameTxtBox.Text = value; }
        }
        public string Suffix
        {
            get { return SuffixTxtBox.Text; }
            set { SuffixTxtBox.Text = value; }
        }
        public string CompanyName
        {
            get { return CompanyNameTxtBox.Text; }
            set { CompanyNameTxtBox.Text = value; }
        }
        public string Phone
        {
            get { return PhoneTxtBox.Text; }
            set { PhoneTxtBox.Text = value; }
        }

        public ChangeInfoForm()
        {
            InitializeComponent();
        }
    }
}

using ITMO.ADO2023.FinalTask.AdventureWorksLT2012DataSetTableAdapters;
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
    public partial class LoginsPasswords : Form
    {
        DataView customerDataView;
        DataTable customerDataTable;

        public LoginsPasswords()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(adventureWorksLT2012DataSet1.Customer);
            salesOrderDetailTableAdapter1.Fill(adventureWorksLT2012DataSet1.SalesOrderDetail);
            customerDataView = new DataView(adventureWorksLT2012DataSet1.Customer);
            customerDataView.Sort = "CustomerID";

            customerDataTable = customerDataView.ToTable();
            customerDataTable.Columns.Remove("NameStyle");
            customerDataTable.Columns.Remove("Title");
            customerDataTable.Columns.Remove("FirstName");
            customerDataTable.Columns.Remove("MiddleName");
            customerDataTable.Columns.Remove("LastName");
            customerDataTable.Columns.Remove("Suffix");
            customerDataTable.Columns.Remove("SalesPerson");
            customerDataTable.Columns.Remove("PasswordHash");
            customerDataTable.Columns.Remove("rowguid");
            customerDataTable.Columns.Remove("ModifiedDate");
            customerDataTable.Columns.Remove("CompanyName");
            customerDataTable.Columns.Remove("Phone");
            customerDataTable.Columns["PasswordSalt"].ColumnName = "Password";

            CustomerGrid.DataSource = customerDataTable;
        }
    }
}

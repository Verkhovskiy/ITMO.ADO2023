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
    public partial class AdminPage : Form
    {
        DataView customerDataView;
        DataView salesOrderHeaderDataView;
        public LoginForm parent;
        public AdminPage()
        {
            InitializeComponent();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Close();
        }

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!parent.Visible)
            {
                parent.Close();
            }
        }

        private void AdminPage_Load(object sender, EventArgs e)
        {
            customerTableAdapter1.Fill(adventureWorksLT2012DataSet1.Customer);
            salesOrderHeaderTableAdapter1.Fill(adventureWorksLT2012DataSet1.SalesOrderHeader);
            customerDataView = new DataView(adventureWorksLT2012DataSet1.Customer);
            salesOrderHeaderDataView = new DataView(adventureWorksLT2012DataSet1.SalesOrderHeader);
            customerDataView.Sort = "CustomerID";
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.adventureWorksLT2012DataSet1);

        }

        private void customerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectedCustomerID = customerDataGridView.SelectedCells[0].OwningRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString();
            DataRowView selectedRow = customerDataView[customerDataView.Find(selectedCustomerID)];
            salesOrderHeaderDataView = selectedRow.CreateChildView(adventureWorksLT2012DataSet1.Relations["FK_SalesOrderHeader_Customer_CustomerID"]);
            OrdersGrid.DataSource = salesOrderHeaderDataView;
        }
    }
}

namespace ITMO.ADO2023.FinalTask
{
    partial class LoginsPasswords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CustomerGrid = new System.Windows.Forms.DataGridView();
            this.customerTableAdapter1 = new ITMO.ADO2023.FinalTask.AdventureWorksLT2012DataSetTableAdapters.CustomerTableAdapter();
            this.adventureWorksLT2012DataSet1 = new ITMO.ADO2023.FinalTask.AdventureWorksLT2012DataSet();
            this.salesOrderDetailTableAdapter1 = new ITMO.ADO2023.FinalTask.AdventureWorksLT2012DataSetTableAdapters.SalesOrderDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2012DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGrid
            // 
            this.CustomerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerGrid.Location = new System.Drawing.Point(0, 0);
            this.CustomerGrid.Name = "CustomerGrid";
            this.CustomerGrid.Size = new System.Drawing.Size(488, 561);
            this.CustomerGrid.TabIndex = 0;
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // adventureWorksLT2012DataSet1
            // 
            this.adventureWorksLT2012DataSet1.DataSetName = "AdventureWorksLT2012DataSet";
            this.adventureWorksLT2012DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesOrderDetailTableAdapter1
            // 
            this.salesOrderDetailTableAdapter1.ClearBeforeFill = true;
            // 
            // LoginsPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 561);
            this.Controls.Add(this.CustomerGrid);
            this.Name = "LoginsPasswords";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2012DataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerGrid;
        private AdventureWorksLT2012DataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private AdventureWorksLT2012DataSet adventureWorksLT2012DataSet1;
        private AdventureWorksLT2012DataSetTableAdapters.SalesOrderDetailTableAdapter salesOrderDetailTableAdapter1;
    }
}
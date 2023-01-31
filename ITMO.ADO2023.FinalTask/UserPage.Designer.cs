namespace ITMO.ADO2023.FinalTask
{
    partial class UserPage
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
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.GreetLabel = new System.Windows.Forms.Label();
            this.UserDataLabel = new System.Windows.Forms.Label();
            this.ChangeInfoBtn = new System.Windows.Forms.Button();
            this.ordersView = new System.Windows.Forms.DataGridView();
            this.customerTableAdapter1 = new ITMO.ADO2023.FinalTask.AdventureWorksLT2012DataSetTableAdapters.CustomerTableAdapter();
            this.adventureWorksLT2012DataSet1 = new ITMO.ADO2023.FinalTask.AdventureWorksLT2012DataSet();
            this.salesOrderHeaderTableAdapter1 = new ITMO.ADO2023.FinalTask.AdventureWorksLT2012DataSetTableAdapters.SalesOrderHeaderTableAdapter();
            this.addOrderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2012DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.Location = new System.Drawing.Point(713, 415);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(75, 23);
            this.LogoutBtn.TabIndex = 0;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = true;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // GreetLabel
            // 
            this.GreetLabel.AutoSize = true;
            this.GreetLabel.Location = new System.Drawing.Point(12, 9);
            this.GreetLabel.Name = "GreetLabel";
            this.GreetLabel.Size = new System.Drawing.Size(59, 13);
            this.GreetLabel.TabIndex = 1;
            this.GreetLabel.Text = "GreetLabel";
            // 
            // UserDataLabel
            // 
            this.UserDataLabel.AutoSize = true;
            this.UserDataLabel.Location = new System.Drawing.Point(12, 403);
            this.UserDataLabel.Name = "UserDataLabel";
            this.UserDataLabel.Size = new System.Drawing.Size(78, 13);
            this.UserDataLabel.TabIndex = 2;
            this.UserDataLabel.Text = "UserDataLabel";
            // 
            // ChangeInfoBtn
            // 
            this.ChangeInfoBtn.Location = new System.Drawing.Point(582, 415);
            this.ChangeInfoBtn.Name = "ChangeInfoBtn";
            this.ChangeInfoBtn.Size = new System.Drawing.Size(125, 23);
            this.ChangeInfoBtn.TabIndex = 3;
            this.ChangeInfoBtn.Text = "Change Personal Info";
            this.ChangeInfoBtn.UseVisualStyleBackColor = true;
            this.ChangeInfoBtn.Click += new System.EventHandler(this.ChangeInfoBtn_Click);
            // 
            // ordersView
            // 
            this.ordersView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersView.Location = new System.Drawing.Point(12, 36);
            this.ordersView.Name = "ordersView";
            this.ordersView.Size = new System.Drawing.Size(776, 354);
            this.ordersView.TabIndex = 4;
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
            // salesOrderHeaderTableAdapter1
            // 
            this.salesOrderHeaderTableAdapter1.ClearBeforeFill = true;
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Location = new System.Drawing.Point(713, 7);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(75, 23);
            this.addOrderBtn.TabIndex = 5;
            this.addOrderBtn.Text = "Add Order";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click);
            // 
            // UserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addOrderBtn);
            this.Controls.Add(this.ordersView);
            this.Controls.Add(this.ChangeInfoBtn);
            this.Controls.Add(this.UserDataLabel);
            this.Controls.Add(this.GreetLabel);
            this.Controls.Add(this.LogoutBtn);
            this.Name = "UserPage";
            this.Text = "User Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserPage_FormClosing);
            this.Load += new System.EventHandler(this.UserPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorksLT2012DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label GreetLabel;
        private System.Windows.Forms.Label UserDataLabel;
        private System.Windows.Forms.Button ChangeInfoBtn;
        private System.Windows.Forms.DataGridView ordersView;
        private AdventureWorksLT2012DataSetTableAdapters.CustomerTableAdapter customerTableAdapter1;
        private AdventureWorksLT2012DataSet adventureWorksLT2012DataSet1;
        private AdventureWorksLT2012DataSetTableAdapters.SalesOrderHeaderTableAdapter salesOrderHeaderTableAdapter1;
        private System.Windows.Forms.Button addOrderBtn;
    }
}
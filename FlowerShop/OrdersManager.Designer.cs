namespace FlowerShop
{
    partial class OrdersManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersManager));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backBtn = new System.Windows.Forms.ToolStripButton();
            this.backLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newOrderBtn = new System.Windows.Forms.ToolStripButton();
            this.newOrderLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addFlowerBtn = new System.Windows.Forms.ToolStripButton();
            this.addNewFlowerLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.generateReportLbl = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.printBtn = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.salesChartBtn = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.ordersGroupBox = new System.Windows.Forms.GroupBox();
            this.ordersLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowersGroupBox = new System.Windows.Forms.GroupBox();
            this.flowersLV = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pieChartControl1 = new FlowerShop.PieChartControl();
            this.toolStrip1.SuspendLayout();
            this.ordersGroupBox.SuspendLayout();
            this.flowersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backBtn,
            this.backLbl,
            this.toolStripSeparator1,
            this.newOrderBtn,
            this.newOrderLbl,
            this.toolStripSeparator2,
            this.addFlowerBtn,
            this.addNewFlowerLbl,
            this.toolStripSeparator3,
            this.generateReportLbl,
            this.toolStripSeparator4,
            this.printBtn,
            this.toolStripSeparator5,
            this.salesChartBtn,
            this.toolStripSeparator6,
            this.refreshBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1120, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backBtn
            // 
            this.backBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(23, 22);
            this.backBtn.Text = "toolStripButton1";
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // backLbl
            // 
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(32, 22);
            this.backLbl.Text = "Back";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // newOrderBtn
            // 
            this.newOrderBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newOrderBtn.Image = ((System.Drawing.Image)(resources.GetObject("newOrderBtn.Image")));
            this.newOrderBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newOrderBtn.Name = "newOrderBtn";
            this.newOrderBtn.Size = new System.Drawing.Size(23, 22);
            this.newOrderBtn.Text = "toolStripButton1";
            this.newOrderBtn.Click += new System.EventHandler(this.newOrderBtn_Click);
            // 
            // newOrderLbl
            // 
            this.newOrderLbl.Name = "newOrderLbl";
            this.newOrderLbl.Size = new System.Drawing.Size(95, 22);
            this.newOrderLbl.Text = "Place New Order";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addFlowerBtn
            // 
            this.addFlowerBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addFlowerBtn.Image = ((System.Drawing.Image)(resources.GetObject("addFlowerBtn.Image")));
            this.addFlowerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFlowerBtn.Name = "addFlowerBtn";
            this.addFlowerBtn.Size = new System.Drawing.Size(23, 22);
            this.addFlowerBtn.Text = "toolStripButton1";
            this.addFlowerBtn.Click += new System.EventHandler(this.addFlowerBtn_Click);
            // 
            // addNewFlowerLbl
            // 
            this.addNewFlowerLbl.Name = "addNewFlowerLbl";
            this.addNewFlowerLbl.Size = new System.Drawing.Size(105, 22);
            this.addNewFlowerLbl.Text = "Add A New Flower";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // generateReportLbl
            // 
            this.generateReportLbl.Name = "generateReportLbl";
            this.generateReportLbl.Size = new System.Drawing.Size(92, 22);
            this.generateReportLbl.Text = "Generate Report";
            this.generateReportLbl.Click += new System.EventHandler(this.generateReportLbl_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // printBtn
            // 
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(70, 22);
            this.printBtn.Text = "Print Report";
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // salesChartBtn
            // 
            this.salesChartBtn.Name = "salesChartBtn";
            this.salesChartBtn.Size = new System.Drawing.Size(65, 22);
            this.salesChartBtn.Text = "Sales Chart";
            this.salesChartBtn.Click += new System.EventHandler(this.salesChartBtn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // refreshBtn
            // 
            this.refreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(23, 22);
            this.refreshBtn.Text = "toolStripButton1";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // ordersGroupBox
            // 
            this.ordersGroupBox.Controls.Add(this.ordersLV);
            this.ordersGroupBox.Location = new System.Drawing.Point(566, 251);
            this.ordersGroupBox.Name = "ordersGroupBox";
            this.ordersGroupBox.Size = new System.Drawing.Size(542, 248);
            this.ordersGroupBox.TabIndex = 1;
            this.ordersGroupBox.TabStop = false;
            this.ordersGroupBox.Text = "Orders";
            // 
            // ordersLV
            // 
            this.ordersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Date,
            this.columnHeader2});
            this.ordersLV.Location = new System.Drawing.Point(6, 19);
            this.ordersLV.Name = "ordersLV";
            this.ordersLV.Size = new System.Drawing.Size(529, 201);
            this.ordersLV.TabIndex = 0;
            this.ordersLV.UseCompatibleStateImageBehavior = false;
            this.ordersLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 153;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 145;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Total";
            this.columnHeader2.Width = 150;
            // 
            // flowersGroupBox
            // 
            this.flowersGroupBox.Controls.Add(this.flowersLV);
            this.flowersGroupBox.Location = new System.Drawing.Point(566, 29);
            this.flowersGroupBox.Name = "flowersGroupBox";
            this.flowersGroupBox.Size = new System.Drawing.Size(542, 216);
            this.flowersGroupBox.TabIndex = 2;
            this.flowersGroupBox.TabStop = false;
            this.flowersGroupBox.Text = "Flowers";
            // 
            // flowersLV
            // 
            this.flowersLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.flowersLV.Location = new System.Drawing.Point(6, 20);
            this.flowersLV.Name = "flowersLV";
            this.flowersLV.Size = new System.Drawing.Size(529, 185);
            this.flowersLV.TabIndex = 1;
            this.flowersLV.UseCompatibleStateImageBehavior = false;
            this.flowersLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 167;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Price";
            this.columnHeader4.Width = 161;
            // 
            // pieChartControl1
            // 
            this.pieChartControl1.Location = new System.Drawing.Point(12, 95);
            this.pieChartControl1.Name = "pieChartControl1";
            this.pieChartControl1.Size = new System.Drawing.Size(372, 302);
            this.pieChartControl1.TabIndex = 3;
            // 
            // OrdersManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 500);
            this.Controls.Add(this.pieChartControl1);
            this.Controls.Add(this.ordersGroupBox);
            this.Controls.Add(this.flowersGroupBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "OrdersManager";
            this.Text = "Orders Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrdersManager_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ordersGroupBox.ResumeLayout(false);
            this.flowersGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backBtn;
        private System.Windows.Forms.ToolStripLabel backLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton newOrderBtn;
        private System.Windows.Forms.ToolStripLabel newOrderLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton addFlowerBtn;
        private System.Windows.Forms.ToolStripLabel addNewFlowerLbl;
        private System.Windows.Forms.GroupBox ordersGroupBox;
        private System.Windows.Forms.GroupBox flowersGroupBox;
        private System.Windows.Forms.ListView ordersLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView flowersLV;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton refreshBtn;
        private System.Windows.Forms.ToolStripLabel generateReportLbl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel printBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel salesChartBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

        private PieChartControl pieChartControl = new PieChartControl();
        private PieChartControl pieChartControl1;
    }
}
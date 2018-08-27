namespace FlowerShop
{
    partial class NewOrder
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
            this.addItemBox = new System.Windows.Forms.GroupBox();
            this.nbOfFlowers2TB = new System.Windows.Forms.TextBox();
            this.secondFlowerTypeCmb = new System.Windows.Forms.ComboBox();
            this.nbFlowers2Lbl = new System.Windows.Forms.Label();
            this.secondFlowerTypeLbl = new System.Windows.Forms.Label();
            this.nbOfFlowers1TB = new System.Windows.Forms.TextBox();
            this.finishOrderButton = new System.Windows.Forms.Button();
            this.nbFlowers1Lbl = new System.Windows.Forms.Label();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.addRibbonCheck = new System.Windows.Forms.CheckBox();
            this.ribbonLbl = new System.Windows.Forms.Label();
            this.arrangementTypeCmbBox = new System.Windows.Forms.ComboBox();
            this.arrangementTypeLbl = new System.Windows.Forms.Label();
            this.flowerTypesCmbBox = new System.Windows.Forms.ComboBox();
            this.typeLbl = new System.Windows.Forms.Label();
            this.currentOrderBox = new System.Windows.Forms.GroupBox();
            this.newOrderLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backBtn = new System.Windows.Forms.ToolStripButton();
            this.backLbl = new System.Windows.Forms.ToolStripLabel();
            this.nbOfFlowers1EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.nbOfFlowers2EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowerType1EP = new System.Windows.Forms.ErrorProvider(this.components);
            this.arrangementTypeEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.secondTypeEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.newOrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addItemBox.SuspendLayout();
            this.currentOrderBox.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbOfFlowers1EP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbOfFlowers2EP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerType1EP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrangementTypeEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTypeEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOrderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addItemBox
            // 
            this.addItemBox.Controls.Add(this.nbOfFlowers2TB);
            this.addItemBox.Controls.Add(this.secondFlowerTypeCmb);
            this.addItemBox.Controls.Add(this.nbFlowers2Lbl);
            this.addItemBox.Controls.Add(this.secondFlowerTypeLbl);
            this.addItemBox.Controls.Add(this.nbOfFlowers1TB);
            this.addItemBox.Controls.Add(this.finishOrderButton);
            this.addItemBox.Controls.Add(this.nbFlowers1Lbl);
            this.addItemBox.Controls.Add(this.addItemBtn);
            this.addItemBox.Controls.Add(this.addRibbonCheck);
            this.addItemBox.Controls.Add(this.ribbonLbl);
            this.addItemBox.Controls.Add(this.arrangementTypeCmbBox);
            this.addItemBox.Controls.Add(this.arrangementTypeLbl);
            this.addItemBox.Controls.Add(this.flowerTypesCmbBox);
            this.addItemBox.Controls.Add(this.typeLbl);
            this.addItemBox.Location = new System.Drawing.Point(13, 30);
            this.addItemBox.Name = "addItemBox";
            this.addItemBox.Size = new System.Drawing.Size(426, 388);
            this.addItemBox.TabIndex = 0;
            this.addItemBox.TabStop = false;
            this.addItemBox.Text = "Add An Item";
            // 
            // nbOfFlowers2TB
            // 
            this.nbOfFlowers2TB.Location = new System.Drawing.Point(120, 156);
            this.nbOfFlowers2TB.Name = "nbOfFlowers2TB";
            this.nbOfFlowers2TB.Size = new System.Drawing.Size(121, 20);
            this.nbOfFlowers2TB.TabIndex = 13;
            this.nbOfFlowers2TB.Validating += new System.ComponentModel.CancelEventHandler(this.nbOfFlowers2TB_Validating);
            this.nbOfFlowers2TB.Validated += new System.EventHandler(this.nbOfFlowers2TB_Validated);
            // 
            // secondFlowerTypeCmb
            // 
            this.secondFlowerTypeCmb.FormattingEnabled = true;
            this.secondFlowerTypeCmb.Location = new System.Drawing.Point(120, 129);
            this.secondFlowerTypeCmb.Name = "secondFlowerTypeCmb";
            this.secondFlowerTypeCmb.Size = new System.Drawing.Size(121, 21);
            this.secondFlowerTypeCmb.TabIndex = 12;
            this.secondFlowerTypeCmb.Validated += new System.EventHandler(this.secondFlowerTypeCmb_Validated);
            // 
            // nbFlowers2Lbl
            // 
            this.nbFlowers2Lbl.AutoSize = true;
            this.nbFlowers2Lbl.Location = new System.Drawing.Point(5, 163);
            this.nbFlowers2Lbl.Name = "nbFlowers2Lbl";
            this.nbFlowers2Lbl.Size = new System.Drawing.Size(104, 13);
            this.nbFlowers2Lbl.TabIndex = 11;
            this.nbFlowers2Lbl.Text = "Number of Flowers 2";
            // 
            // secondFlowerTypeLbl
            // 
            this.secondFlowerTypeLbl.AutoSize = true;
            this.secondFlowerTypeLbl.Location = new System.Drawing.Point(5, 137);
            this.secondFlowerTypeLbl.Name = "secondFlowerTypeLbl";
            this.secondFlowerTypeLbl.Size = new System.Drawing.Size(105, 13);
            this.secondFlowerTypeLbl.TabIndex = 10;
            this.secondFlowerTypeLbl.Text = "Second Flower Type";
            // 
            // nbOfFlowers1TB
            // 
            this.nbOfFlowers1TB.Location = new System.Drawing.Point(120, 103);
            this.nbOfFlowers1TB.Name = "nbOfFlowers1TB";
            this.nbOfFlowers1TB.Size = new System.Drawing.Size(121, 20);
            this.nbOfFlowers1TB.TabIndex = 9;
            this.nbOfFlowers1TB.Validating += new System.ComponentModel.CancelEventHandler(this.nbOfFlowers1TB_Validating);
            this.nbOfFlowers1TB.Validated += new System.EventHandler(this.nbOfFlowers1TB_Validated);
            // 
            // finishOrderButton
            // 
            this.finishOrderButton.Location = new System.Drawing.Point(259, 343);
            this.finishOrderButton.Name = "finishOrderButton";
            this.finishOrderButton.Size = new System.Drawing.Size(114, 36);
            this.finishOrderButton.TabIndex = 8;
            this.finishOrderButton.Text = "Finish Order";
            this.finishOrderButton.UseVisualStyleBackColor = true;
            this.finishOrderButton.Click += new System.EventHandler(this.finishOrderButton_Click);
            // 
            // nbFlowers1Lbl
            // 
            this.nbFlowers1Lbl.AutoSize = true;
            this.nbFlowers1Lbl.Location = new System.Drawing.Point(7, 110);
            this.nbFlowers1Lbl.Name = "nbFlowers1Lbl";
            this.nbFlowers1Lbl.Size = new System.Drawing.Size(104, 13);
            this.nbFlowers1Lbl.TabIndex = 7;
            this.nbFlowers1Lbl.Text = "Number of Flowers 1";
            // 
            // addItemBtn
            // 
            this.addItemBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addItemBtn.Location = new System.Drawing.Point(25, 346);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(114, 33);
            this.addItemBtn.TabIndex = 6;
            this.addItemBtn.Text = "Add Item To Order";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.addItemBtn_Click);
            // 
            // addRibbonCheck
            // 
            this.addRibbonCheck.AutoSize = true;
            this.addRibbonCheck.Location = new System.Drawing.Point(120, 77);
            this.addRibbonCheck.Name = "addRibbonCheck";
            this.addRibbonCheck.Size = new System.Drawing.Size(15, 14);
            this.addRibbonCheck.TabIndex = 5;
            this.addRibbonCheck.UseVisualStyleBackColor = true;
            // 
            // ribbonLbl
            // 
            this.ribbonLbl.AutoSize = true;
            this.ribbonLbl.Location = new System.Drawing.Point(7, 78);
            this.ribbonLbl.Name = "ribbonLbl";
            this.ribbonLbl.Size = new System.Drawing.Size(92, 13);
            this.ribbonLbl.TabIndex = 4;
            this.ribbonLbl.Text = "Add Silk Ribbon ?";
            // 
            // arrangementTypeCmbBox
            // 
            this.arrangementTypeCmbBox.FormattingEnabled = true;
            this.arrangementTypeCmbBox.Items.AddRange(new object[] {
            "Bouquet",
            "Basket"});
            this.arrangementTypeCmbBox.Location = new System.Drawing.Point(120, 44);
            this.arrangementTypeCmbBox.Name = "arrangementTypeCmbBox";
            this.arrangementTypeCmbBox.Size = new System.Drawing.Size(121, 21);
            this.arrangementTypeCmbBox.TabIndex = 3;
            this.arrangementTypeCmbBox.TextChanged += new System.EventHandler(this.arrangementTypeCmbBox_TextChanged);
            this.arrangementTypeCmbBox.Validated += new System.EventHandler(this.arrangementTypeCmbBox_Validated);
            // 
            // arrangementTypeLbl
            // 
            this.arrangementTypeLbl.AutoSize = true;
            this.arrangementTypeLbl.Location = new System.Drawing.Point(7, 47);
            this.arrangementTypeLbl.Name = "arrangementTypeLbl";
            this.arrangementTypeLbl.Size = new System.Drawing.Size(94, 13);
            this.arrangementTypeLbl.TabIndex = 2;
            this.arrangementTypeLbl.Text = "Arrangement Type";
            // 
            // flowerTypesCmbBox
            // 
            this.flowerTypesCmbBox.FormattingEnabled = true;
            this.flowerTypesCmbBox.Location = new System.Drawing.Point(120, 17);
            this.flowerTypesCmbBox.Name = "flowerTypesCmbBox";
            this.flowerTypesCmbBox.Size = new System.Drawing.Size(121, 21);
            this.flowerTypesCmbBox.TabIndex = 1;
            this.flowerTypesCmbBox.Validated += new System.EventHandler(this.flowerTypesCmbBox_Validated);
            // 
            // typeLbl
            // 
            this.typeLbl.AutoSize = true;
            this.typeLbl.Location = new System.Drawing.Point(7, 20);
            this.typeLbl.Name = "typeLbl";
            this.typeLbl.Size = new System.Drawing.Size(65, 13);
            this.typeLbl.TabIndex = 0;
            this.typeLbl.Text = "Flower Type";
            // 
            // currentOrderBox
            // 
            this.currentOrderBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentOrderBox.Controls.Add(this.newOrderLV);
            this.currentOrderBox.Location = new System.Drawing.Point(446, 13);
            this.currentOrderBox.Name = "currentOrderBox";
            this.currentOrderBox.Size = new System.Drawing.Size(769, 405);
            this.currentOrderBox.TabIndex = 1;
            this.currentOrderBox.TabStop = false;
            this.currentOrderBox.Text = "Your Basket";
            // 
            // newOrderLV
            // 
            this.newOrderLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newOrderLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "Flower_Type";
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "Arrangement_Type";
            listViewGroup3.Header = "ListViewGroup";
            listViewGroup3.Name = "Silk_Ribbon";
            this.newOrderLV.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3});
            this.newOrderLV.Location = new System.Drawing.Point(7, 34);
            this.newOrderLV.Name = "newOrderLV";
            this.newOrderLV.Size = new System.Drawing.Size(756, 362);
            this.newOrderLV.TabIndex = 0;
            this.newOrderLV.UseCompatibleStateImageBehavior = false;
            this.newOrderLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Arrangement Type";
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Flower Type";
            this.columnHeader2.Width = 102;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Number of First Flower";
            this.columnHeader3.Width = 126;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Second Flower Type";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Number Of Second Flower";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ribbon?";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Price";
            this.columnHeader7.Width = 53;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backBtn,
            this.backLbl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1227, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // backBtn
            // 
            this.backBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(23, 22);
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // backLbl
            // 
            this.backLbl.Name = "backLbl";
            this.backLbl.Size = new System.Drawing.Size(32, 22);
            this.backLbl.Text = "Back";
            // 
            // nbOfFlowers1EP
            // 
            this.nbOfFlowers1EP.ContainerControl = this;
            // 
            // nbOfFlowers2EP
            // 
            this.nbOfFlowers2EP.ContainerControl = this;
            // 
            // flowerType1EP
            // 
            this.flowerType1EP.ContainerControl = this;
            // 
            // arrangementTypeEP
            // 
            this.arrangementTypeEP.ContainerControl = this;
            // 
            // secondTypeEP
            // 
            this.secondTypeEP.ContainerControl = this;
            // 
            // newOrderBindingSource
            // 
            this.newOrderBindingSource.DataSource = typeof(FlowerShop.NewOrder);
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 457);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.currentOrderBox);
            this.Controls.Add(this.addItemBox);
            this.Name = "NewOrder";
            this.Text = "Place Your New Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewOrder_FormClosing);
            this.addItemBox.ResumeLayout(false);
            this.addItemBox.PerformLayout();
            this.currentOrderBox.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbOfFlowers1EP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbOfFlowers2EP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerType1EP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrangementTypeEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondTypeEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newOrderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox addItemBox;
        private System.Windows.Forms.ComboBox arrangementTypeCmbBox;
        private System.Windows.Forms.Label arrangementTypeLbl;
        private System.Windows.Forms.ComboBox flowerTypesCmbBox;
        private System.Windows.Forms.Label typeLbl;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.CheckBox addRibbonCheck;
        private System.Windows.Forms.Label ribbonLbl;
        private System.Windows.Forms.GroupBox currentOrderBox;
        private System.Windows.Forms.ListView newOrderLV;
        private System.Windows.Forms.BindingSource newOrderBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backBtn;
        private System.Windows.Forms.ToolStripLabel backLbl;
        private System.Windows.Forms.Label nbFlowers1Lbl;
        private System.Windows.Forms.Button finishOrderButton;
        private System.Windows.Forms.TextBox nbOfFlowers2TB;
        private System.Windows.Forms.ComboBox secondFlowerTypeCmb;
        private System.Windows.Forms.Label nbFlowers2Lbl;
        private System.Windows.Forms.Label secondFlowerTypeLbl;
        private System.Windows.Forms.TextBox nbOfFlowers1TB;
        private System.Windows.Forms.ErrorProvider nbOfFlowers1EP;
        private System.Windows.Forms.ErrorProvider nbOfFlowers2EP;
        private System.Windows.Forms.ErrorProvider flowerType1EP;
        private System.Windows.Forms.ErrorProvider arrangementTypeEP;
        private System.Windows.Forms.ErrorProvider secondTypeEP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}
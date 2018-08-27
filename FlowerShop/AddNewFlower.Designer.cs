namespace FlowerShop
{
    partial class AddNewFlower
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewFlower));
            this.flowerNameLbl = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cancelBtn = new System.Windows.Forms.ToolStripButton();
            this.cancelLbl = new System.Windows.Forms.ToolStripLabel();
            this.priceLbl = new System.Windows.Forms.Label();
            this.flowerNameTB = new System.Windows.Forms.TextBox();
            this.priceTB = new System.Windows.Forms.TextBox();
            this.addFlowerBtn = new System.Windows.Forms.Button();
            this.flowerNameEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.flowerPriceEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.importLbl = new System.Windows.Forms.Label();
            this.exampleUC = new ImageExampleControl.ExampleWithImageAndText();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowerNameEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerPriceEP)).BeginInit();
            this.SuspendLayout();
            // 
            // flowerNameLbl
            // 
            this.flowerNameLbl.AutoSize = true;
            this.flowerNameLbl.Location = new System.Drawing.Point(123, 65);
            this.flowerNameLbl.Name = "flowerNameLbl";
            this.flowerNameLbl.Size = new System.Drawing.Size(69, 13);
            this.flowerNameLbl.TabIndex = 0;
            this.flowerNameLbl.Text = "Flower Name";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelBtn,
            this.cancelLbl});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(490, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cancelBtn
            // 
            this.cancelBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(23, 22);
            this.cancelBtn.Text = "toolStripButton1";
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // cancelLbl
            // 
            this.cancelLbl.Name = "cancelLbl";
            this.cancelLbl.Size = new System.Drawing.Size(43, 22);
            this.cancelLbl.Text = "Cancel";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(161, 118);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(31, 13);
            this.priceLbl.TabIndex = 2;
            this.priceLbl.Text = "Price";
            // 
            // flowerNameTB
            // 
            this.flowerNameTB.Location = new System.Drawing.Point(249, 65);
            this.flowerNameTB.Name = "flowerNameTB";
            this.flowerNameTB.Size = new System.Drawing.Size(100, 20);
            this.flowerNameTB.TabIndex = 3;
            this.flowerNameTB.Validating += new System.ComponentModel.CancelEventHandler(this.flowerNameTB_Validating);
            this.flowerNameTB.Validated += new System.EventHandler(this.flowerNameTB_Validated);
            // 
            // priceTB
            // 
            this.priceTB.Location = new System.Drawing.Point(249, 118);
            this.priceTB.Name = "priceTB";
            this.priceTB.Size = new System.Drawing.Size(100, 20);
            this.priceTB.TabIndex = 4;
            this.priceTB.Validating += new System.ComponentModel.CancelEventHandler(this.priceTB_Validating);
            this.priceTB.Validated += new System.EventHandler(this.priceTB_Validated);
            // 
            // addFlowerBtn
            // 
            this.addFlowerBtn.Location = new System.Drawing.Point(194, 245);
            this.addFlowerBtn.Name = "addFlowerBtn";
            this.addFlowerBtn.Size = new System.Drawing.Size(100, 33);
            this.addFlowerBtn.TabIndex = 5;
            this.addFlowerBtn.Text = "Add Flower";
            this.addFlowerBtn.UseVisualStyleBackColor = true;
            this.addFlowerBtn.Click += new System.EventHandler(this.addFlowerBtn_Click);
            // 
            // flowerNameEP
            // 
            this.flowerNameEP.ContainerControl = this;
            // 
            // flowerPriceEP
            // 
            this.flowerPriceEP.ContainerControl = this;
            // 
            // importLbl
            // 
            this.importLbl.AutoSize = true;
            this.importLbl.Location = new System.Drawing.Point(246, 333);
            this.importLbl.Name = "importLbl";
            this.importLbl.Size = new System.Drawing.Size(234, 13);
            this.importLbl.TabIndex = 6;
            this.importLbl.Text = "Drag-and-Drop a flowers .txt file to import flowers";
            // 
            // exampleUC
            // 
            this.exampleUC.Location = new System.Drawing.Point(108, 144);
            this.exampleUC.Name = "exampleUC";
            this.exampleUC.Size = new System.Drawing.Size(266, 95);
            this.exampleUC.TabIndex = 7;
            // 
            // AddNewFlower
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 355);
            this.Controls.Add(this.exampleUC);
            this.Controls.Add(this.importLbl);
            this.Controls.Add(this.addFlowerBtn);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.flowerNameTB);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.flowerNameLbl);
            this.Name = "AddNewFlower";
            this.Text = "AddNewFlower";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddNewFlower_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.AddNewFlower_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.AddNewFlower_DragEnter);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flowerNameEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerPriceEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label flowerNameLbl;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cancelBtn;
        private System.Windows.Forms.ToolStripLabel cancelLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.TextBox flowerNameTB;
        private System.Windows.Forms.TextBox priceTB;
        private System.Windows.Forms.Button addFlowerBtn;
        private System.Windows.Forms.ErrorProvider flowerNameEP;
        private System.Windows.Forms.ErrorProvider flowerPriceEP;
        private System.Windows.Forms.Label importLbl;
        private ImageExampleControl.ExampleWithImageAndText exampleUC;
    }
}
namespace FlowerShop
{
    partial class Flowery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flowery));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileMenuItemTS = new System.Windows.Forms.ToolStripMenuItem();
            this.placeAnOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFlowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItemTS = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItemTS = new System.Windows.Forms.ToolStripMenuItem();
            this.titlePagePB = new System.Windows.Forms.PictureBox();
            this.placeNewOrderBtn = new System.Windows.Forms.Button();
            this.addNewFlowerBtn = new System.Windows.Forms.Button();
            this.manageShopBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePagePB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItemTS,
            this.aboutMenuItemTS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1404, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItemTS
            // 
            this.fileMenuItemTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeAnOrderToolStripMenuItem,
            this.addNewFlowerToolStripMenuItem,
            this.manageOrdersToolStripMenuItem,
            this.exitMenuItemTS});
            this.fileMenuItemTS.Name = "fileMenuItemTS";
            this.fileMenuItemTS.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItemTS.Text = "File";
            // 
            // placeAnOrderToolStripMenuItem
            // 
            this.placeAnOrderToolStripMenuItem.Name = "placeAnOrderToolStripMenuItem";
            this.placeAnOrderToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.placeAnOrderToolStripMenuItem.Text = "Place An &Order";
            this.placeAnOrderToolStripMenuItem.Click += new System.EventHandler(this.placeAnOrderToolStripMenuItem_Click);
            // 
            // addNewFlowerToolStripMenuItem
            // 
            this.addNewFlowerToolStripMenuItem.Name = "addNewFlowerToolStripMenuItem";
            this.addNewFlowerToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.addNewFlowerToolStripMenuItem.Text = "Add New &Flower";
            this.addNewFlowerToolStripMenuItem.Click += new System.EventHandler(this.addNewFlowerToolStripMenuItem_Click);
            // 
            // manageOrdersToolStripMenuItem
            // 
            this.manageOrdersToolStripMenuItem.Name = "manageOrdersToolStripMenuItem";
            this.manageOrdersToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.manageOrdersToolStripMenuItem.Text = "Manage &Store";
            this.manageOrdersToolStripMenuItem.Click += new System.EventHandler(this.manageOrdersToolStripMenuItem_Click);
            // 
            // exitMenuItemTS
            // 
            this.exitMenuItemTS.Name = "exitMenuItemTS";
            this.exitMenuItemTS.Size = new System.Drawing.Size(161, 22);
            this.exitMenuItemTS.Text = "&Exit";
            this.exitMenuItemTS.Click += new System.EventHandler(this.exitMenuItemTS_Click);
            // 
            // aboutMenuItemTS
            // 
            this.aboutMenuItemTS.Name = "aboutMenuItemTS";
            this.aboutMenuItemTS.Size = new System.Drawing.Size(52, 20);
            this.aboutMenuItemTS.Text = "&About";
            this.aboutMenuItemTS.Click += new System.EventHandler(this.aboutMenuItemTS_Click);
            // 
            // titlePagePB
            // 
            this.titlePagePB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titlePagePB.Image = ((System.Drawing.Image)(resources.GetObject("titlePagePB.Image")));
            this.titlePagePB.ImageLocation = "";
            this.titlePagePB.InitialImage = ((System.Drawing.Image)(resources.GetObject("titlePagePB.InitialImage")));
            this.titlePagePB.Location = new System.Drawing.Point(13, 28);
            this.titlePagePB.Name = "titlePagePB";
            this.titlePagePB.Size = new System.Drawing.Size(1379, 510);
            this.titlePagePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlePagePB.TabIndex = 1;
            this.titlePagePB.TabStop = false;
            // 
            // placeNewOrderBtn
            // 
            this.placeNewOrderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.placeNewOrderBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.placeNewOrderBtn.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeNewOrderBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.placeNewOrderBtn.Location = new System.Drawing.Point(294, 346);
            this.placeNewOrderBtn.Name = "placeNewOrderBtn";
            this.placeNewOrderBtn.Size = new System.Drawing.Size(146, 56);
            this.placeNewOrderBtn.TabIndex = 2;
            this.placeNewOrderBtn.Text = "Place New Order";
            this.placeNewOrderBtn.UseVisualStyleBackColor = false;
            this.placeNewOrderBtn.Click += new System.EventHandler(this.placeNewOrderBtn_Click);
            // 
            // addNewFlowerBtn
            // 
            this.addNewFlowerBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addNewFlowerBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.addNewFlowerBtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewFlowerBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addNewFlowerBtn.Location = new System.Drawing.Point(605, 347);
            this.addNewFlowerBtn.Name = "addNewFlowerBtn";
            this.addNewFlowerBtn.Size = new System.Drawing.Size(159, 55);
            this.addNewFlowerBtn.TabIndex = 3;
            this.addNewFlowerBtn.Text = "Add New Flower";
            this.addNewFlowerBtn.UseVisualStyleBackColor = false;
            this.addNewFlowerBtn.Click += new System.EventHandler(this.addNewFlowerBtn_Click);
            // 
            // manageShopBtn
            // 
            this.manageShopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.manageShopBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.manageShopBtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageShopBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.manageShopBtn.Location = new System.Drawing.Point(921, 347);
            this.manageShopBtn.Name = "manageShopBtn";
            this.manageShopBtn.Size = new System.Drawing.Size(159, 55);
            this.manageShopBtn.TabIndex = 4;
            this.manageShopBtn.Text = "Manage Store";
            this.manageShopBtn.UseVisualStyleBackColor = false;
            this.manageShopBtn.Click += new System.EventHandler(this.manageShopBtn_Click);
            // 
            // Flowery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 550);
            this.Controls.Add(this.manageShopBtn);
            this.Controls.Add(this.addNewFlowerBtn);
            this.Controls.Add(this.placeNewOrderBtn);
            this.Controls.Add(this.titlePagePB);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Flowery";
            this.Text = "Flowery";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.titlePagePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItemTS;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItemTS;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItemTS;
        private System.Windows.Forms.ToolStripMenuItem placeAnOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrdersToolStripMenuItem;
        private System.Windows.Forms.PictureBox titlePagePB;
        private System.Windows.Forms.Button placeNewOrderBtn;
        private System.Windows.Forms.ToolStripMenuItem addNewFlowerToolStripMenuItem;
        private System.Windows.Forms.Button addNewFlowerBtn;
        private System.Windows.Forms.Button manageShopBtn;
    }
}


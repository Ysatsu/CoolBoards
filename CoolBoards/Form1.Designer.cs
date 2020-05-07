namespace CoolBoards
{
    partial class frmCoolBoard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sloganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxOrderNum = new System.Windows.Forms.TextBox();
            this.txtBxQuantity = new System.Windows.Forms.TextBox();
            this.grpBxSize = new System.Windows.Forms.GroupBox();
            this.radBtnDefault = new System.Windows.Forms.RadioButton();
            this.radBtnXXL = new System.Windows.Forms.RadioButton();
            this.radBtnExtraLarge = new System.Windows.Forms.RadioButton();
            this.radBtnLarge = new System.Windows.Forms.RadioButton();
            this.radBtnMedium = new System.Windows.Forms.RadioButton();
            this.radBtnSmall = new System.Windows.Forms.RadioButton();
            this.grpBxExtras = new System.Windows.Forms.GroupBox();
            this.chckBxPocket = new System.Windows.Forms.CheckBox();
            this.chckBxMonogram = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBxPrice = new System.Windows.Forms.TextBox();
            this.txtBxOrderTotal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnClearSummary = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picBxLogo = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.rchTxtBxSlogan = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.grpBxSize.SuspendLayout();
            this.grpBxExtras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(718, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.summaryToolStripMenuItem.Text = "S&ummary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToOrderToolStripMenuItem,
            this.clearItemToolStripMenuItem,
            this.submitOrderToolStripMenuItem});
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.saleToolStripMenuItem.Text = "&Sale";
            // 
            // addToOrderToolStripMenuItem
            // 
            this.addToOrderToolStripMenuItem.Name = "addToOrderToolStripMenuItem";
            this.addToOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToOrderToolStripMenuItem.Text = "&Add to Order";
            this.addToOrderToolStripMenuItem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // clearItemToolStripMenuItem
            // 
            this.clearItemToolStripMenuItem.Name = "clearItemToolStripMenuItem";
            this.clearItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearItemToolStripMenuItem.Text = "Clear &Item";
            this.clearItemToolStripMenuItem.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // submitOrderToolStripMenuItem
            // 
            this.submitOrderToolStripMenuItem.Name = "submitOrderToolStripMenuItem";
            this.submitOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.submitOrderToolStripMenuItem.Text = "Submit &Order";
            this.submitOrderToolStripMenuItem.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.sloganToolStripMenuItem,
            this.logoToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.displayToolStripMenuItem.Text = "&Display";
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fontToolStripMenuItem.Text = "Fo&nt";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.colorToolStripMenuItem.Text = "Co&lor";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // sloganToolStripMenuItem
            // 
            this.sloganToolStripMenuItem.Name = "sloganToolStripMenuItem";
            this.sloganToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sloganToolStripMenuItem.Text = "Slo&gan";
            this.sloganToolStripMenuItem.Click += new System.EventHandler(this.sloganToolStripMenuItem_Click);
            // 
            // logoToolStripMenuItem
            // 
            this.logoToolStripMenuItem.Name = "logoToolStripMenuItem";
            this.logoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logoToolStripMenuItem.Text = "Logo";
            this.logoToolStripMenuItem.Click += new System.EventHandler(this.logoToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(142, 92);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(114, 20);
            this.txtBxName.TabIndex = 4;
            // 
            // txtBxOrderNum
            // 
            this.txtBxOrderNum.Location = new System.Drawing.Point(142, 49);
            this.txtBxOrderNum.Name = "txtBxOrderNum";
            this.txtBxOrderNum.ReadOnly = true;
            this.txtBxOrderNum.Size = new System.Drawing.Size(114, 20);
            this.txtBxOrderNum.TabIndex = 5;
            // 
            // txtBxQuantity
            // 
            this.txtBxQuantity.Location = new System.Drawing.Point(142, 135);
            this.txtBxQuantity.Name = "txtBxQuantity";
            this.txtBxQuantity.Size = new System.Drawing.Size(114, 20);
            this.txtBxQuantity.TabIndex = 6;
            // 
            // grpBxSize
            // 
            this.grpBxSize.Controls.Add(this.radBtnDefault);
            this.grpBxSize.Controls.Add(this.radBtnXXL);
            this.grpBxSize.Controls.Add(this.radBtnExtraLarge);
            this.grpBxSize.Controls.Add(this.radBtnLarge);
            this.grpBxSize.Controls.Add(this.radBtnMedium);
            this.grpBxSize.Controls.Add(this.radBtnSmall);
            this.grpBxSize.Location = new System.Drawing.Point(49, 191);
            this.grpBxSize.Name = "grpBxSize";
            this.grpBxSize.Size = new System.Drawing.Size(187, 223);
            this.grpBxSize.TabIndex = 7;
            this.grpBxSize.TabStop = false;
            this.grpBxSize.Text = "Size";
            // 
            // radBtnDefault
            // 
            this.radBtnDefault.AutoSize = true;
            this.radBtnDefault.Checked = true;
            this.radBtnDefault.Location = new System.Drawing.Point(93, 19);
            this.radBtnDefault.Name = "radBtnDefault";
            this.radBtnDefault.Size = new System.Drawing.Size(85, 17);
            this.radBtnDefault.TabIndex = 5;
            this.radBtnDefault.TabStop = true;
            this.radBtnDefault.Text = "radioButton1";
            this.radBtnDefault.UseVisualStyleBackColor = true;
            this.radBtnDefault.Visible = false;
            // 
            // radBtnXXL
            // 
            this.radBtnXXL.AutoSize = true;
            this.radBtnXXL.Location = new System.Drawing.Point(24, 184);
            this.radBtnXXL.Name = "radBtnXXL";
            this.radBtnXXL.Size = new System.Drawing.Size(45, 17);
            this.radBtnXXL.TabIndex = 4;
            this.radBtnXXL.Text = "XXL";
            this.radBtnXXL.UseVisualStyleBackColor = true;
            this.radBtnXXL.CheckedChanged += new System.EventHandler(this.radBtnSmall_CheckedChanged_1);
            // 
            // radBtnExtraLarge
            // 
            this.radBtnExtraLarge.AutoSize = true;
            this.radBtnExtraLarge.Location = new System.Drawing.Point(24, 146);
            this.radBtnExtraLarge.Name = "radBtnExtraLarge";
            this.radBtnExtraLarge.Size = new System.Drawing.Size(79, 17);
            this.radBtnExtraLarge.TabIndex = 3;
            this.radBtnExtraLarge.Text = "Extra Large";
            this.radBtnExtraLarge.UseVisualStyleBackColor = true;
            this.radBtnExtraLarge.CheckedChanged += new System.EventHandler(this.radBtnSmall_CheckedChanged_1);
            // 
            // radBtnLarge
            // 
            this.radBtnLarge.AutoSize = true;
            this.radBtnLarge.Location = new System.Drawing.Point(24, 108);
            this.radBtnLarge.Name = "radBtnLarge";
            this.radBtnLarge.Size = new System.Drawing.Size(52, 17);
            this.radBtnLarge.TabIndex = 2;
            this.radBtnLarge.Text = "Large";
            this.radBtnLarge.UseVisualStyleBackColor = true;
            this.radBtnLarge.CheckedChanged += new System.EventHandler(this.radBtnSmall_CheckedChanged_1);
            // 
            // radBtnMedium
            // 
            this.radBtnMedium.AutoSize = true;
            this.radBtnMedium.Location = new System.Drawing.Point(24, 70);
            this.radBtnMedium.Name = "radBtnMedium";
            this.radBtnMedium.Size = new System.Drawing.Size(62, 17);
            this.radBtnMedium.TabIndex = 1;
            this.radBtnMedium.Text = "Medium";
            this.radBtnMedium.UseVisualStyleBackColor = true;
            this.radBtnMedium.CheckedChanged += new System.EventHandler(this.radBtnSmall_CheckedChanged_1);
            // 
            // radBtnSmall
            // 
            this.radBtnSmall.AutoSize = true;
            this.radBtnSmall.Location = new System.Drawing.Point(23, 33);
            this.radBtnSmall.Name = "radBtnSmall";
            this.radBtnSmall.Size = new System.Drawing.Size(50, 17);
            this.radBtnSmall.TabIndex = 0;
            this.radBtnSmall.Text = "Small";
            this.radBtnSmall.UseVisualStyleBackColor = true;
            this.radBtnSmall.CheckedChanged += new System.EventHandler(this.radBtnSmall_CheckedChanged_1);
            // 
            // grpBxExtras
            // 
            this.grpBxExtras.Controls.Add(this.chckBxPocket);
            this.grpBxExtras.Controls.Add(this.chckBxMonogram);
            this.grpBxExtras.Location = new System.Drawing.Point(297, 198);
            this.grpBxExtras.Name = "grpBxExtras";
            this.grpBxExtras.Size = new System.Drawing.Size(158, 93);
            this.grpBxExtras.TabIndex = 9;
            this.grpBxExtras.TabStop = false;
            this.grpBxExtras.Text = "Extras";
            // 
            // chckBxPocket
            // 
            this.chckBxPocket.AutoSize = true;
            this.chckBxPocket.Location = new System.Drawing.Point(17, 63);
            this.chckBxPocket.Name = "chckBxPocket";
            this.chckBxPocket.Size = new System.Drawing.Size(60, 17);
            this.chckBxPocket.TabIndex = 1;
            this.chckBxPocket.Text = "Pocket";
            this.chckBxPocket.UseVisualStyleBackColor = true;
            this.chckBxPocket.CheckedChanged += new System.EventHandler(this.chckBxMonogram_CheckedChanged);
            // 
            // chckBxMonogram
            // 
            this.chckBxMonogram.AutoSize = true;
            this.chckBxMonogram.Location = new System.Drawing.Point(17, 26);
            this.chckBxMonogram.Name = "chckBxMonogram";
            this.chckBxMonogram.Size = new System.Drawing.Size(76, 17);
            this.chckBxMonogram.TabIndex = 0;
            this.chckBxMonogram.Text = "Monogram";
            this.chckBxMonogram.UseVisualStyleBackColor = true;
            this.chckBxMonogram.CheckedChanged += new System.EventHandler(this.chckBxMonogram_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Shirt Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Order Total:";
            // 
            // txtBxPrice
            // 
            this.txtBxPrice.Location = new System.Drawing.Point(358, 324);
            this.txtBxPrice.Name = "txtBxPrice";
            this.txtBxPrice.Size = new System.Drawing.Size(99, 20);
            this.txtBxPrice.TabIndex = 12;
            // 
            // txtBxOrderTotal
            // 
            this.txtBxOrderTotal.Location = new System.Drawing.Point(358, 372);
            this.txtBxOrderTotal.Name = "txtBxOrderTotal";
            this.txtBxOrderTotal.Size = new System.Drawing.Size(99, 20);
            this.txtBxOrderTotal.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(515, 229);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 25);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "&Add to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Location = new System.Drawing.Point(515, 279);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 25);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit &Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(515, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 25);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear This &Item";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(515, 379);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(127, 25);
            this.btnSummary.TabIndex = 18;
            this.btnSummary.Text = "&Summary of All Orders";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnClearSummary
            // 
            this.btnClearSummary.Location = new System.Drawing.Point(515, 429);
            this.btnClearSummary.Name = "btnClearSummary";
            this.btnClearSummary.Size = new System.Drawing.Size(127, 25);
            this.btnClearSummary.TabIndex = 19;
            this.btnClearSummary.Text = "&Clear Summary";
            this.btnClearSummary.UseVisualStyleBackColor = true;
            this.btnClearSummary.Click += new System.EventHandler(this.btnClearSummary_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(515, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(127, 25);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picBxLogo
            // 
            this.picBxLogo.Image = global::CoolBoards.Properties.Resources.baseball_logo_template_design_1251_6;
            this.picBxLogo.Location = new System.Drawing.Point(497, 39);
            this.picBxLogo.Name = "picBxLogo";
            this.picBxLogo.Size = new System.Drawing.Size(158, 165);
            this.picBxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBxLogo.TabIndex = 14;
            this.picBxLogo.TabStop = false;
            this.picBxLogo.Visible = false;
            // 
            // rchTxtBxSlogan
            // 
            this.rchTxtBxSlogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtBxSlogan.Location = new System.Drawing.Point(282, 52);
            this.rchTxtBxSlogan.Name = "rchTxtBxSlogan";
            this.rchTxtBxSlogan.ReadOnly = true;
            this.rchTxtBxSlogan.Size = new System.Drawing.Size(189, 106);
            this.rchTxtBxSlogan.TabIndex = 21;
            this.rchTxtBxSlogan.Text = "Look up, Get up, but Never give up!";
            this.rchTxtBxSlogan.Visible = false;
            // 
            // frmCoolBoard
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 523);
            this.Controls.Add(this.rchTxtBxSlogan);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearSummary);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picBxLogo);
            this.Controls.Add(this.txtBxOrderTotal);
            this.Controls.Add(this.txtBxPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpBxExtras);
            this.Controls.Add(this.grpBxSize);
            this.Controls.Add(this.txtBxQuantity);
            this.Controls.Add(this.txtBxOrderNum);
            this.Controls.Add(this.txtBxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCoolBoard";
            this.Text = "Order Input";
            this.Load += new System.EventHandler(this.frmCoolBoard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBxSize.ResumeLayout(false);
            this.grpBxSize.PerformLayout();
            this.grpBxExtras.ResumeLayout(false);
            this.grpBxExtras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sloganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxOrderNum;
        private System.Windows.Forms.TextBox txtBxQuantity;
        private System.Windows.Forms.GroupBox grpBxSize;
        private System.Windows.Forms.RadioButton radBtnXXL;
        private System.Windows.Forms.RadioButton radBtnExtraLarge;
        private System.Windows.Forms.RadioButton radBtnLarge;
        private System.Windows.Forms.RadioButton radBtnMedium;
        private System.Windows.Forms.RadioButton radBtnSmall;
        private System.Windows.Forms.GroupBox grpBxExtras;
        private System.Windows.Forms.CheckBox chckBxPocket;
        private System.Windows.Forms.CheckBox chckBxMonogram;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBxPrice;
        private System.Windows.Forms.TextBox txtBxOrderTotal;
        private System.Windows.Forms.PictureBox picBxLogo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnClearSummary;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RichTextBox rchTxtBxSlogan;
        private System.Windows.Forms.RadioButton radBtnDefault;
    }
}


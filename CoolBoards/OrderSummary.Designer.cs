namespace CoolBoards
{
    partial class frmOrderSummary
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
            this.lblNumOrder = new System.Windows.Forms.Label();
            this.lblNumShirts = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblNumOrdersAnswer = new System.Windows.Forms.Label();
            this.lblNumShirtsAnswer = new System.Windows.Forms.Label();
            this.lblTotalAnswer = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumOrder
            // 
            this.lblNumOrder.AutoSize = true;
            this.lblNumOrder.Location = new System.Drawing.Point(30, 43);
            this.lblNumOrder.Name = "lblNumOrder";
            this.lblNumOrder.Size = new System.Drawing.Size(93, 13);
            this.lblNumOrder.TabIndex = 0;
            this.lblNumOrder.Text = "Number of Orders:";
            // 
            // lblNumShirts
            // 
            this.lblNumShirts.AutoSize = true;
            this.lblNumShirts.Location = new System.Drawing.Point(30, 134);
            this.lblNumShirts.Name = "lblNumShirts";
            this.lblNumShirts.Size = new System.Drawing.Size(88, 13);
            this.lblNumShirts.TabIndex = 1;
            this.lblNumShirts.Text = "Number of Shirts:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(30, 225);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            // 
            // lblNumOrdersAnswer
            // 
            this.lblNumOrdersAnswer.Location = new System.Drawing.Point(177, 43);
            this.lblNumOrdersAnswer.Name = "lblNumOrdersAnswer";
            this.lblNumOrdersAnswer.Size = new System.Drawing.Size(100, 23);
            this.lblNumOrdersAnswer.TabIndex = 3;
            // 
            // lblNumShirtsAnswer
            // 
            this.lblNumShirtsAnswer.Location = new System.Drawing.Point(177, 134);
            this.lblNumShirtsAnswer.Name = "lblNumShirtsAnswer";
            this.lblNumShirtsAnswer.Size = new System.Drawing.Size(100, 23);
            this.lblNumShirtsAnswer.TabIndex = 4;
            // 
            // lblTotalAnswer
            // 
            this.lblTotalAnswer.Location = new System.Drawing.Point(177, 225);
            this.lblTotalAnswer.Name = "lblTotalAnswer";
            this.lblTotalAnswer.Size = new System.Drawing.Size(100, 23);
            this.lblTotalAnswer.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(322, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmOrderSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 290);
            this.Controls.Add(this.lblTotalAnswer);
            this.Controls.Add(this.lblNumShirtsAnswer);
            this.Controls.Add(this.lblNumOrdersAnswer);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblNumShirts);
            this.Controls.Add(this.lblNumOrder);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmOrderSummary";
            this.Text = "Order Summary";
            this.Activated += new System.EventHandler(this.frmOrderSummary_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumOrder;
        private System.Windows.Forms.Label lblNumShirts;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblNumOrdersAnswer;
        private System.Windows.Forms.Label lblNumShirtsAnswer;
        private System.Windows.Forms.Label lblTotalAnswer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}
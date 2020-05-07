using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolBoards
{
    public partial class frmOrderSummary : Form
    {
        public frmOrderSummary()
        {
            InitializeComponent();
        }

        private void frmOrderSummary_Activated(object sender, EventArgs e)
        {
            frmCoolBoard theCoolBoard = new frmCoolBoard();
            lblNumOrdersAnswer.Text = theCoolBoard.OrderNum.ToString("n0");
            lblNumShirtsAnswer.Text = theCoolBoard.NumShirts.ToString("n0");
            lblTotalAnswer.Text = theCoolBoard.Total.ToString("c2");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

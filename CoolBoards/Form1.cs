using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Satsuki Yamamoto
//Programming 1
//Cool Boards
//5/10/2018

namespace CoolBoards
{
    public partial class frmCoolBoard : Form
    {
        //global variables
        private static int intNumOrder = 0;
        private static int intNumShirts = 0;
        private static double dblTotal = 0;

        string strQuantityAnswer;
        int intQuantityAnswer;
        double dblShirtPrice, dblTotalPrice;
        int DisplayOrderNum = 1;


        public frmCoolBoard()
        {
            InitializeComponent();
        }

        private void radBtnSmall_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                const double SML = 10, XL = 11, XXL = 12;
                strQuantityAnswer = txtBxQuantity.Text;
                intQuantityAnswer = Convert.ToInt32(strQuantityAnswer);
                RadioButton selectedRadioButton;
                selectedRadioButton = (RadioButton)sender;
                switch (selectedRadioButton.Name)
                {
                    case "radBtnSmall":
                        dblShirtPrice = SML;
                        break;
                    case "radBtnMedium":
                        dblShirtPrice = SML;
                        break;
                    case "radBtnLarge":
                        dblShirtPrice = SML;
                        break;
                    case "radBtnExtraLarge":
                        dblShirtPrice = XL;
                        break;
                    case "radBtnXXL":
                        dblShirtPrice = XXL;
                        break;
           
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter the number of Quantity before selecting size", "Error");
                txtBxQuantity.Focus();
                txtBxPrice.Text = "";
                txtBxOrderTotal.Text = "";
                chckBxMonogram.Checked = false;
                chckBxPocket.Checked = false; 
            }

            txtBxPrice.Text = dblShirtPrice.ToString("n2");
            dblTotalPrice = dblShirtPrice * intQuantityAnswer;
            txtBxOrderTotal.Text = dblTotalPrice.ToString("n2");
            txtBxName.ReadOnly = true;
           

        }

        private void chckBxMonogram_CheckedChanged(object sender, EventArgs e)
        {
            const double MONOGRAM = 2, POCKET = 1;
            double dblExtraMono = 0;
            double dblExtraPocket = 0;
            double dblExtra;
            double dblSubtotal;

            if (chckBxMonogram.Checked == true)
            {
                dblExtraMono = MONOGRAM;
            }
            else
            {
                dblExtraMono = 0;
            }

            if(chckBxPocket.Checked == true)
            {
                dblExtraPocket = POCKET;
            }
            else
            {
                dblExtraPocket = 0;
            }

            dblExtra = dblExtraMono + dblExtraPocket;
            dblSubtotal = dblShirtPrice + dblExtra;
            txtBxPrice.Text = dblSubtotal.ToString("n2");
            dblTotalPrice = dblSubtotal * intQuantityAnswer;
            txtBxOrderTotal.Text = dblTotalPrice.ToString("n2");


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBxName.Text = "";
            txtBxQuantity.Text = "";
            txtBxPrice.Text = "";
            txtBxOrderTotal.Text = ""; 
            radBtnDefault.Checked = true;
        }

        private void btnClearSummary_Click(object sender, EventArgs e)
        {
            txtBxName.Text = "";
            txtBxQuantity.Text = "";
            txtBxPrice.Text = "";
            txtBxOrderTotal.Text = "";
            txtBxOrderNum.Text = ""; 
            
            chckBxMonogram.Checked = false;
            chckBxPocket.Checked = false;
            txtBxName.ReadOnly = false;
            dblTotalPrice = 0;
            intNumOrder = 0;
            intNumShirts = 0;
            dblTotal = 0;
            intQuantityAnswer = 0;
            DisplayOrderNum = 1;
            txtBxOrderNum.Text = DisplayOrderNum.ToString("n0");
            txtBxName.Focus();
        }

        private void sloganToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(sloganToolStripMenuItem.Checked == true)
            {
                sloganToolStripMenuItem.Checked = false;
                rchTxtBxSlogan.Visible = false;
            }
            else
            {
                sloganToolStripMenuItem.Checked = true;
                rchTxtBxSlogan.Visible = true;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = rchTxtBxSlogan.Font;
            if(fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                rchTxtBxSlogan.Font = fontDialog1.Font;
            }
                
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = rchTxtBxSlogan.ForeColor;
            if(colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                rchTxtBxSlogan.ForeColor = colorDialog1.Color;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            DialogResult responseDialogResult;

            responseDialogResult = MessageBox.Show("Do you want to submit this order?", "Confirm", MessageBoxButtons.YesNo);

            if(responseDialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Your order is submitted", "Success");
                txtBxName.ReadOnly = false;
                btnAdd.Enabled = true;
                radBtnDefault.Checked = true;
                dblTotalPrice = 0;
                intQuantityAnswer = 0;
                DisplayOrderNum++;
                txtBxOrderNum.Text = DisplayOrderNum.ToString("n0");
                intNumOrder++;
            }
            else
            {
                MessageBox.Show("Your order is cancelled", "Cancel");

                txtBxQuantity.Text = "";
                radBtnDefault.Checked = true;
                chckBxMonogram.Checked = false;
                chckBxPocket.Checked = false;
                txtBxPrice.Text = ""; 
                txtBxOrderTotal.Text = ""; 
                intQuantityAnswer = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                strQuantityAnswer = txtBxQuantity.Text;
                intQuantityAnswer = Convert.ToInt32(strQuantityAnswer);
                dblTotal += dblTotalPrice;
                intNumShirts += intQuantityAnswer;
                
                MessageBox.Show("Your selected item is added", "Success");

                if (intQuantityAnswer <= 0)
                {
                    MessageBox.Show("Quantity must be greater than 0.", "Error");
                    txtBxQuantity.SelectAll();
                    txtBxQuantity.Focus();
                }

                if(radBtnDefault.Checked == true)
                {
                    MessageBox.Show("Select a size.", "Error");
                    grpBxSize.Focus();
                    
                }

                else
                {
                    radBtnDefault.Checked = true;
                    chckBxMonogram.Checked = false;
                    chckBxPocket.Checked = false;
                    btnSubmit.Enabled = true;
                    txtBxName.ReadOnly = true;
                    txtBxPrice.Text = "";
                    txtBxOrderTotal.Text = "";
                    txtBxQuantity.Text = "";
                    txtBxQuantity.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a number", "Error");
                txtBxQuantity.SelectAll();
                txtBxQuantity.Focus();
                
            }
        }
 
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void logoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(logoToolStripMenuItem.Checked)
            {
                logoToolStripMenuItem.Checked = false;
                picBxLogo.Visible = false;
            }
            else
            {
                logoToolStripMenuItem.Checked = true;
                picBxLogo.Visible = true;
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            frmOrderSummary theOrderSummary = new frmOrderSummary();
            theOrderSummary.ShowDialog();
            txtBxName.ReadOnly = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout1 anAboutForm1 = new frmAbout1();
            anAboutForm1.ShowDialog();
        }

        public int OrderNum
        {
            get
            {
                return intNumOrder;
            }
        }

        public int NumShirts
        {
            get
            {
                return intNumShirts;
            }
        }
        public double Total
        {
            get
            {
                return dblTotal;
            }
        }

        private void frmCoolBoard_Load(object sender, EventArgs e)
        {
            txtBxOrderNum.Text = DisplayOrderNum.ToString("n0");
        }

       
    }
}

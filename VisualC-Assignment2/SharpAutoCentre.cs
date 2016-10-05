using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualC_Assignment2
{
    public partial class SharpAutoCentre : Form
    {
        public SharpAutoCentre()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Closes the window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Clears all of the text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            SalesTaxTextBox.Text = "";
            SubTotalTextBox.Text = "";
            BaseTextBox.Text = "";
            AdditionalTextBox.Text = "";
            TotalTextBox.Text = "";
            TradeInTextBox.Text = "";
            AmountDueTextBox.Text = "";
        }
        /// <summary>
        /// Will preform calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double BasePrice;
            double SubTotal;
            double SalesTax;
            double Total;
            double TradeIn;
            double AmountDue;
            //put additional options here 
            //actual math now
            BasePrice = Convert.ToDouble(BaseTextBox.Text);

        }
        /// <summary>
        /// This will open a message box to talk about things
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program will help you calculate the priceing for when you want to buy a new car!", "Sharp Auto Centre");
        }
        /// <summary>
        /// All the checkboxes and Radiobuttons edit the baseprice when checked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SteroCheckBox.Checked == true)
            {
                BasePrice = BasePrice + 425.76;
            }

        }

        private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LeatherInteriorCheckBox.Checked == true)
            {
                BasePrice = BasePrice + 987.41;
            }
        }

        private void ComputerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ComputerCheckBox.Checked == true)
            {
                BasePrice = BasePrice + 1741.23;
            }
        }

        private void StandardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StandardRadioButton.Checked == true)
            {
                BasePrice = BasePrice;
            }
        }

        private void PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PearlizedRadioButton.Checked == true)
            {
                BasePrice = BasePrice + 345.72;
            }
        }

        private void CustomizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomizedRadioButton.Checked == true)
            {
                BasePrice = BasePrice + 599.99;
            }
        }
    }
}

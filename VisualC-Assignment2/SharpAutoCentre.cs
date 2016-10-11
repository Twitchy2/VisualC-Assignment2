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
        private double BasePrice;
        private double Aditional;
        private double SubTotal;
        private double SalesTax;
        private double Total;
        private double TradeIn;
        private double AmountDue;
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
            EndProgram();
        }

        private void EndProgram()
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
            ClearEverything();
        }
        /// <summary>
        /// This method houses the clear options
        /// </summary>
        private void ClearEverything()
        {
            SalesTaxTextBox.Text = "";
            SubTotalTextBox.Text = "";
            BaseTextBox.Text = "";
            AdditionalTextBox.Text = "";
            TotalTextBox.Text = "";
            TradeInTextBox.Text = "";
            AmountDueTextBox.Text = "";
            ComputerCheckBox.Checked = false;
            LeatherInteriorCheckBox.Checked = false;
            PearlizedRadioButton.Checked = false;
            SteroCheckBox.Checked = false;
            CustomizedRadioButton.Checked = false;
            StandardRadioButton.Checked = false;
        }

        /// <summary>
        /// Will preform calculations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Caclcuate();

        }
        /// <summary>
        /// Uses math to calculate all of our text boxes and whatnot in the program
        /// </summary>
        private void Caclcuate()
        {
            //put additional options here 
            //actual math now
            BasePrice = Convert.ToDouble(BaseTextBox.Text);
            TradeIn = Convert.ToDouble(TradeInTextBox.Text);


                AdditionalTextBox.Text = Aditional.ToString("C2");

                SubTotal = BasePrice + Aditional;
                SubTotalTextBox.Text = SubTotal.ToString("C2");

                SalesTax = SubTotal * 0.13;
                SalesTaxTextBox.Text = SalesTax.ToString("C2");

                Total = SubTotal + SalesTax;
                TotalTextBox.Text = Total.ToString("C2");

                AmountDue = Total - TradeIn;
                AmountDueTextBox.Text = AmountDue.ToString("C2");


        }

        /// <summary>
        /// This will open a message box to talk about things
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program will help you calculate the pricing for when you want to buy a new car!", "Sharp Auto Centre");
        }
        /// <summary>
        /// All the checkboxes and Radiobuttons edit the baseprice when checked as well as aditional prices
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SteroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SteroCheckBox.Checked == true)
            {
                BasePrice = BasePrice + 425.76;
                Aditional = Aditional + 425.76;
            }

        }

        private void LeatherInteriorCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (LeatherInteriorCheckBox.Checked == true)
            {
                BasePrice = BasePrice + 987.41;
                Aditional = Aditional + 987.41;
            }
        }

        private void ComputerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ComputerCheckBox.Checked == true)
            {
                BasePrice = BasePrice + 1741.23;
                Aditional = Aditional + 1741.23;
            }
        }

        private void StandardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (StandardRadioButton.Checked == true)
            {
                BasePrice = BasePrice;
                Aditional = Aditional;
            }
        }

        private void PearlizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (PearlizedRadioButton.Checked == true)
            {
                BasePrice = BasePrice + 345.72;
                Aditional = Aditional + 345.72;
            }
        }

        private void CustomizedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomizedRadioButton.Checked == true)
            {
                BasePrice = BasePrice + 599.99;
                Aditional = Aditional + 599.99;
            }
        }
        /// <summary>
        /// Calculates as well
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Caclcuate();
        }
        /// <summary>
        /// clears all text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearEverything();
        }
        /// <summary>
        /// See below
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndProgram();
        }
        /// <summary>
        /// Closes the program totally
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SharpAutoCentre_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Changes all of the font to what is selected on the font dialouge box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                BaseLabel.Font = fontDialog.Font;
                AdditionalLabel.Font = fontDialog.Font;
                SubTotalLabel.Font = fontDialog.Font;
                SalesTaxLabel.Font = fontDialog.Font;
                TotalLabel.Font = fontDialog.Font;
                TradeInLabel.Font = fontDialog.Font;
                AmountLabel.Font = fontDialog.Font;

                AdditionalGroupBox.Font = fontDialog.Font;
                SteroCheckBox.Font = fontDialog.Font;
                LeatherInteriorCheckBox.Font = fontDialog.Font;
                ComputerCheckBox.Font = fontDialog.Font;

                ExteriorGroupBox.Font = fontDialog.Font;
                CustomizedRadioButton.Font = fontDialog.Font;
                StandardRadioButton.Font = fontDialog.Font;
                PearlizedRadioButton.Font = fontDialog.Font;

                CalculateButton.Font = fontDialog.Font;
                ClearButton.Font = fontDialog.Font;
                ExitButton.Font = fontDialog.Font;
            }
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colourDialog = new ColorDialog();
            if (colourDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colourDialog.Color;
            }
        }
    }
}

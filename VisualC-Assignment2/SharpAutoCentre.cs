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

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            double BasePrice;
            double SubTotal;
            double SalesTax;
            double Total;
            double TradeIn;
            double AmountDue;
            //put additional options here 
            BasePrice = Convert.ToDouble(BaseTextBox.Text);

        }
    }
}

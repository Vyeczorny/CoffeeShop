using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class AddProductToCardWindow : Form
    {
        public AddProductToCardWindow(string name, float price, int max)
        {
            noOfProducts = max;
            InitializeComponent();
            productNameLabel.Text = name;
            singlePrice = price;
            priceTextBox.Text = "0 zł";
        }

        public int Counter
        {
            get
            {
                return (int)counterUpDown.Value;
            }
        }


        private void counterUpDown_ValueChanged(object sender, EventArgs e)
        {
            priceTextBox.Text = ((int)counterUpDown.Value * singlePrice).ToString() + " zł";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (Counter > noOfProducts)
            {
                if (MessageBox.Show("Uwaga: nasz sklep posiada w tej chwili jedynie " + noOfProducts + " sztuk(i) wybranego produktu, dlatego zamówienie może być wykonane z opóźnieniem", "Uwaga", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private int noOfProducts;
        private float singlePrice;
    }
}

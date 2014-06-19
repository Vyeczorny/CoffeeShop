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
    public partial class ProductFormConst : ProductForm
    {
        public ProductFormConst(ListViewItem i)
        {
            InitializeComponent();
            nameBox.Enabled = false;
            describeBox.Enabled = false;
            priceBox.Enabled = false;
            countBox.Enabled = false;

            nameBox.Text = i.SubItems[1].Text;
            describeBox.Text = i.SubItems[2].Text;
            priceBox.Text = i.SubItems[3].Text;
            countBox.Text = i.SubItems[4].Text;
        }

        public override void updateProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}

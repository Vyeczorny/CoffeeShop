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
    public partial class UpdateProductWindow : Form
    {
        public UpdateProductWindow(ListViewItem i)
        {
            item = i;

            InitializeComponent();
            nameBox.Text = item.SubItems[3].Text;
            describeBox.Text = item.SubItems[2].Text;
            priceBox.Text = item.SubItems[1].Text;
            countBox.Text = item.SubItems[4].Text;
        }

        private ListViewItem item;

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            item.SubItems[1].Text = priceBox.Text;
            item.SubItems[2].Text = describeBox.Text;
            item.SubItems[3].Text = nameBox.Text;
            item.SubItems[4].Text = countBox.Text;

            this.Close();
        }
    }
}

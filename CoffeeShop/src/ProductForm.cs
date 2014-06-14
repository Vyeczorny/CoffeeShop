using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public abstract partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        public  abstract void updateProductButton_MouseClick(object sender, MouseEventArgs e);

        protected ListViewItem item;
    }
}

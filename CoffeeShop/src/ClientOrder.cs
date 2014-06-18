using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CoffeeShop
{
    public abstract partial class ClientOrder : Form
    {
        public ClientOrder()
        {
            InitializeComponent();
        }

        protected abstract void okButton_Click(object sender, EventArgs e);
        protected abstract void addButton_Click(object sender, EventArgs e);
        protected abstract void statusComboBox_SelectedIndexChanged(object sender, EventArgs e);
    }
}

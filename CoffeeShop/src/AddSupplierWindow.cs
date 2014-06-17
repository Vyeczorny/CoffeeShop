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
    public partial class AddSupplierWindow : Form
    {
        public AddSupplierWindow()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(supplierNameTextBox.Text))
                MessageBox.Show("Pole 'Nazwa' nie może być puste!");
            else if (string.IsNullOrWhiteSpace(supplierAccountTextBox.Text))
                MessageBox.Show("Pole 'Numer konta' nie może byc puste!");
            else
            {
                PostgreSQL.executeCommand("INSERT INTO dostawca(nazwa, nr_konta) VALUES ("
                    + "'" + supplierNameTextBox.Text + "',"
                    + "'" + supplierAccountTextBox.Text + "')"
                    );
                this.Close();
            }
            
        }
    }
}

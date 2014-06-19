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
    public partial class SupplierProductForm : Form
    {
        public SupplierProductForm(string id)
        {
            supplierId = id;
            InitializeComponent();

            NpgsqlDataReader reader = PostgreSQL.executeCommand("(SELECT kod_prod, nazwa FROM produkt) "
                +"EXCEPT (SELECT kod_prod, nazwa FROM dostawca_dostarcza_produkt NATURAL JOIN produkt WHERE kod_dost=" + id + ")");
            while (reader.Read())
                productComboBox.Items.Add(reader[0] + ". " + reader[1]);
            if(productComboBox.Items.Count > 0)
                productComboBox.SelectedIndex=0;
        }

        public DialogResult ShowDialog()
        {
            if (productComboBox.Items.Count == 0)
            {
                MessageBox.Show("Ten dostawca dostarcza już wszystkie możliwe produkty");
                return DialogResult.Abort;
            }
            else
                return base.ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                string product = productComboBox.Items[productComboBox.SelectedIndex].ToString();
                product = product.Substring(0, product.IndexOf('.'));

                PostgreSQL.executeCommand("INSERT INTO dostawca_dostarcza_produkt values("
                    + supplierId + ","
                    + product + ","
                    + float.Parse(priceTextBox.Text) + ","
                    + int.Parse(countTextBox.Text) + ")"
                    );

                this.Close();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string supplierId;
    }
}

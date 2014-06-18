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
    public partial class DeliveryOrder_AddProductWindow : Form
    {
        public DeliveryOrder_AddProductWindow(int id, List<int> prod)
        {
            supplierId = id;
            if (prod == null)
                forbiddenProducts = new List<int>();
            else
                forbiddenProducts = prod;

            InitializeComponent();
        }

        private void AddSupplierOrder_Load(object sender, EventArgs e)
        {
            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT * FROM produkt NATURAL JOIN dostawca_dostarcza_produkt WHERE kod_dost=" + supplierId);
            while (reader.Read())
                if (!forbiddenProducts.Contains((int)reader[0]))
                    productComboBox.Items.Add(reader[0] + ". " + reader[3]);

            if (productComboBox.Items.Count > 0)
                productComboBox.SelectedItem = productComboBox.Items[0];
            else
                MessageBox.Show("Ten dostawca nie dostarcza żadnych produktów");
        }

        private int supplierId;
        private List<int> forbiddenProducts;
        private double currentPrice;

        private void productComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int max = (int)PostgreSQL.executeScalar("SELECT max_ilosc FROM dostawca_dostarcza_produkt WHERE kod_prod=" + getProductId() + " AND kod_dost=" + supplierId);
            currentPrice = (double)PostgreSQL.executeScalar("SELECT cena_hurt FROM dostawca_dostarcza_produkt WHERE kod_prod=" + getProductId() + " AND kod_dost=" + supplierId);

            countUpDown.Maximum = max;
            priceTextBox.Text = (currentPrice * (float)countUpDown.Value).ToString() + " zl";
        }

        public int getProductId()
        {
            string text = productComboBox.Items[productComboBox.SelectedIndex].ToString();
            int dotPos = text.IndexOf('.');
            return int.Parse(text.Substring(0, dotPos));
        }

        public string getProductName()
        {
            string text = productComboBox.Items[productComboBox.SelectedIndex].ToString();
            int dotPos = text.IndexOf('.');
            return text.Substring(dotPos + 1);
        }

        private void countUpDown_ValueChanged(object sender, EventArgs e)
        {
            priceTextBox.Text = (currentPrice * (float)countUpDown.Value).ToString() + " zl";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

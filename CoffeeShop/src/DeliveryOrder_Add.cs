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
    public partial class DeliveryOrder_Add : DeliveryOrder
    {
        public DeliveryOrder_Add()
        {
            InitializeComponent();
            alreadySelectedProducts = new List<int>();

            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT kod_dost, nazwa FROM dostawca");
            while(reader.Read())
                supplierComboBox.Items.Add(reader[0] + ". " + reader[1]);

            if (supplierComboBox.Items.Count > 0)
                supplierComboBox.SelectedIndex = 0;

            statusComboBox.Enabled = false;
            statusComboBox.Items.Add("Nowe");
            statusComboBox.SelectedIndex = 0;
        }

        protected override void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            priceTextBox.Text = "0 zł";
        }

        protected override void addButton_Click(object sender, EventArgs e)
        {
            DeliveryOrder_AddProductWindow window = new DeliveryOrder_AddProductWindow(getSupplierId(), alreadySelectedProducts);
            DialogResult dr = window.ShowDialog();
            if(dr == DialogResult.OK)
            {
                alreadySelectedProducts.Add(window.getProductId());
                ListViewItem item = listView1.Items.Add(new ListViewItem(window.getProductId().ToString()));
                item.SubItems.Add(window.getProductName());
                item.SubItems.Add(window.countUpDown.Value.ToString());
                item.SubItems.Add(window.priceTextBox.Text);
            }
            priceTextBox.Text = countTotalPrice() + " zł";
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count == 0)
                MessageBox.Show("Nie wybrano żadnych produktów");
            else
            {
                string price = priceTextBox.Text.Substring(0, priceTextBox.Text.IndexOf(' '));
                int noOfOrder = (int)PostgreSQL.executeScalar("INSERT INTO zamowienie_dostawy(kod_dost, koszt, status) values("
                    + getSupplierId() + ",'"
                    + price + "','"
                    + statusComboBox.Text + "') "
                    + "RETURNING nr_zamowienia"
                    );

                foreach(ListViewItem item in listView1.Items)
                {
                    PostgreSQL.executeCommand("INSERT INTO zamowienie_dostawy_zawiera_produkt values("
                    + item.SubItems[0].Text + ","
                    + noOfOrder + ","
                    + item.SubItems[2].Text + ")"
                    );

                    PostgreSQL.executeScalar("UPDATE dostawca_dostarcza_produkt SET "
                        + "max_ilosc=max_ilosc-" + item.SubItems[2].Text + " "
                        + "WHERE kod_dost=" + getSupplierId() + " "
                        + "AND kod_prod=" + item.SubItems[0].Text
                        );
                }
            }

            this.Close();
        }

        private float countTotalPrice()
        {
            float totalPrice = 0.0f;
            foreach(ListViewItem item in listView1.Items)
            {
                string singlePrice = item.SubItems[3].Text.Substring(0, item.SubItems[3].Text.IndexOf(' ')); 
                totalPrice += float.Parse(singlePrice);
            }
            return totalPrice;
        }

        private int getSupplierId()
        {
            string text = supplierComboBox.Items[supplierComboBox.SelectedIndex].ToString();
            int dotPos = text.IndexOf('.');
            return int.Parse(text.Substring(0, dotPos));
        }

        private List<int> alreadySelectedProducts;

    }
}

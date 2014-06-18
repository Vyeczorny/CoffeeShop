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
    public partial class CartWindow : Form
    {
        public CartWindow(Dictionary<int, int> products)
        {
            InitializeComponent();
            chosenProducts = products;
            _totalPrice = 0;
        }

        private void CartWindow_Load(object sender, EventArgs e)
        {
            foreach(var product in chosenProducts)
            {
                NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT kod_prod, nazwa, cena FROM produkt WHERE kod_prod=" + product.Key);
                while(reader.Read())
                {
                    ListViewItem item = listView1.Items.Add(reader[0].ToString());
                    item.SubItems.Add(reader[1].ToString());
                    item.SubItems.Add(product.Value.ToString());
                    item.SubItems.Add(reader[2].ToString());

                    _totalPrice += (product.Value * float.Parse(reader[2].ToString()));
                    updateTotalPrice();
                }
            }
        }

        private void updateTotalPrice()
        {
            totalPriceTextBox.Text = _totalPrice + " zł";
        }

        Dictionary<int, int> chosenProducts;
        private float _totalPrice;
        public float totalPrice
        {
            get
            {
                return _totalPrice;
            }
        }


        private void okButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

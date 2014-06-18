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
    public partial class UserWindow : Form
    {
        public UserWindow()
        {
            InitializeComponent();
            chosenProducts = new Dictionary<int, int>();
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            updateListView();
        }

        private void updateListView()
        {
            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECt * FROM produkt");
            while(reader.Read())
            {
                ListViewItem item = listView1.Items.Add(new ListViewItem(reader[0].ToString()));
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[4].ToString());
            }
        }

        private void addToCartButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                int productId = int.Parse(item.SubItems[0].Text);
                int noOfProducts = int.Parse(item.SubItems[4].Text) - (chosenProducts.ContainsKey(productId) ? chosenProducts[productId] : 0);
                string productName = item.SubItems[1].Text;
                float price = float.Parse(item.SubItems[3].Text);

                AddProductToCardWindow window = new AddProductToCardWindow(productName, price, noOfProducts);
                DialogResult dr = window.ShowDialog();
                if(dr == DialogResult.OK)
                    if (chosenProducts.ContainsKey(productId))
                        chosenProducts[productId] += window.Counter;
                    else
                        chosenProducts[productId] = window.Counter;
                cartButton.Text = "Koszyk (" + chosenProducts.Count + ")";
            }
            else
                MessageBox.Show("Nie wybrane żadnego produktu!");
        }

        private Dictionary<int, int> chosenProducts;
    }
}

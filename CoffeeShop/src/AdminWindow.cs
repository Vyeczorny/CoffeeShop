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
    public partial class AdminWindow : Form
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void AdminWindow_Load(object sender, EventArgs e)
        {
            updateListView1();
            updateListView2();
            updateListView3();
            updateListView4();
        }

        private void updateListView1()
        {
            listView1.Items.Clear(); 
            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT * FROM produkt");

            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; ++i)
                    item.SubItems.Add(reader[i].ToString());
            }
        }

        private void updateListView2()
        {
            listView2.Items.Clear();

            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT * FROM dostawca");

            while (reader.Read())
            {
                ListViewItem item = listView2.Items.Add(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; ++i)
                    item.SubItems.Add(reader[i].ToString());
            }
        }

        private void updateListView3()
        {
            listView3.Items.Clear();

            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECt * FROM zamowienie_dostawy");

            while(reader.Read())
            {
                ListViewItem item = listView3.Items.Add(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; ++i)
                    item.SubItems.Add(reader[i].ToString());
            }
        }

        private void updateListView4()
        {
            listView4.Items.Clear();

            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT * FROM zamowienie_detaliczne");

            while (reader.Read())
            {
                ListViewItem item = listView4.Items.Add(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; ++i)
                    item.SubItems.Add(reader[i].ToString());
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            UpdateProductForm window = new UpdateProductForm(selectedItem);
            window.ShowDialog();
            updateListView1();
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                UpdateProductForm window = new UpdateProductForm(selectedItem);
                window.ShowDialog();
                updateListView1();
            }
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm window = new AddProductForm();
            window.ShowDialog();
            updateListView1();
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                PostgreSQL.executeCommand("DELETE FROM produkt WHERE kod_prod=" + listView1.SelectedItems[0].Text);
                updateListView1();
            }
        }

        private void updateSupplierButton_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                SupplierDetails window = new SupplierDetails(listView2.SelectedItems[0]);
                window.ShowDialog();
                updateListView2();
            }

        }

        private void addSupplierButton_Click(object sender, EventArgs e)
        {
            AddSupplierWindow window = new AddSupplierWindow();
            window.ShowDialog();
            updateListView2();
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            SupplierDetails window = new SupplierDetails(listView2.SelectedItems[0]);
            window.ShowDialog();
            updateListView2();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            DeliveryOrder_Add window = new DeliveryOrder_Add();
            window.ShowDialog();
            updateListView3();
        }

        private void orderDetailsButton_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count > 0)
            {
                DeliveryOrder_Details window = new DeliveryOrder_Details(listView3.SelectedItems[0]);
                window.ShowDialog();
                updateListView3();
                updateListView1();
            }
        }

        private void removeOrderButton_Click(object sender, EventArgs e)
        {
            if(listView3.SelectedItems.Count > 0)
            {
                string orderId = listView3.SelectedItems[0].SubItems[0].Text;
                string supplierId = listView3.SelectedItems[0].SubItems[1].Text;

                if (listView3.SelectedItems[0].SubItems[3].Text == "Nowe")
                {
                    Dictionary<string, string> numberToAdd = new Dictionary<string, string>();
                    NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT * FROM zamowienie_dostawy_zawiera_produkt WHERE nr_zamowienia=" + orderId);
                    while(reader.Read())
                        numberToAdd[reader[0].ToString()] = reader[2].ToString();

                    foreach(var pair in numberToAdd)
                    {
                        PostgreSQL.executeCommand("UPDATE dostawca_dostarcza_produkt "
                            + "SET max_ilosc=max_ilosc+" + pair.Value + " "
                            + "WHERE kod_dost=" + supplierId + " "
                            + "AND kod_prod=" + pair.Key
                            );
                    }

                    PostgreSQL.executeCommand("DELETE FROM zamowienie_dostawy_zawiera_produkt WHERE nr_zamowienia=" + orderId);
                    PostgreSQL.executeCommand("DELETE FROM zamowienie_dostawy WHERE nr_zamowienia=" + orderId);

                    updateListView3();
                }
                else
                    MessageBox.Show("Nie można usunąć zamówienia, które zostało opłacone lub dostarczone");
            }
        }

        private void listView3_DoubleClick(object sender, EventArgs e)
        {
            DeliveryOrder_Details window = new DeliveryOrder_Details(listView3.SelectedItems[0]);
            window.ShowDialog();
            updateListView3();
            updateListView1();
        }

        private void listView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClientOrderDetails window = new ClientOrderDetails(listView4.SelectedItems[0]);
            window.ShowDialog();
            updateListView4();
            updateListView1();
        }
    }
}

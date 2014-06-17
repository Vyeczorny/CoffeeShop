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
        }

        private void updateListView1()
        {
            listView1.Items.Clear();
            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT * FROM produkt");

            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; ++i)
                    item.SubItems.Add(reader[i].ToString().Replace(',', '.'));
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
                    item.SubItems.Add(reader[i].ToString().Replace(',', '.'));
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
    }
}

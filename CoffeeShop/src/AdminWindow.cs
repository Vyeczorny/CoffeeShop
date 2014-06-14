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
            updateListView();
        }

        private void updateListView()
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

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = listView1.SelectedItems[0];
            UpdateProductWindow window = new UpdateProductWindow(selectedItem);
            window.ShowDialog();
            updateListView();
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                UpdateProductWindow window = new UpdateProductWindow(selectedItem);
                window.ShowDialog();
                updateListView();
            }
        }
    }
}

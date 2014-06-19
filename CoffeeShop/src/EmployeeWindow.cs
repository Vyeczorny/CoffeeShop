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
    public partial class EmployeeWindow : Form
    {
        public EmployeeWindow()
        {
            InitializeComponent();
            updateListView4();
        }

        private void updateListView4()
        {
            listView4.Items.Clear();

            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT * FROM zamowienie_detaliczne");

            while (reader.Read())
            {
                ListViewItem item = listView4.Items.Add(reader[0].ToString());
                for (int i = 1; i < reader.FieldCount; ++i)
                    item.SubItems.Add(reader[i].ToString().Replace(',', '.'));
            }
        }

        private void listView4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ClientOrderDetails window = new ClientOrderDetails(listView4.SelectedItems[0]);
            window.ShowDialog();
            updateListView4();
        }
    }
}

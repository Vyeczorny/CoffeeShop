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
    public partial class ClientOrdersWindow : Form
    {
        public ClientOrdersWindow(int id)
        {
            userId = id;
            InitializeComponent();
        }

        private void ClientOrdersWindow_Load(object sender, EventArgs e)
        {
            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT * FROM zamowienie_detaliczne WHERE kod_uz=" + userId);
            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add(new ListViewItem(reader[0].ToString()));
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(reader[3].ToString());
                item.SubItems.Add(reader[4].ToString());
            }
        }

        private int userId;

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

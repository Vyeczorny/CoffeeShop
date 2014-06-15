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
    public partial class SupplierDetails : Form
    {
        public SupplierDetails(ListViewItem i)
        {
            InitializeComponent();
            supplierIdTextBox.Text = i.SubItems[0].Text;
            supplierNameTextBox.Text = i.SubItems[1].Text;
            supplierAccountTextBox.Text = i.SubItems[2].Text;

            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT p.kod_prod, p.nazwa, d.max_ilosc, d.cena_hurt FROM produkt p join dostawca_dostarcza_produkt d using(kod_prod) WHERE kod_dost=" + i.SubItems[0].Text);

            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add(reader[0].ToString());
                for (int j = 1; j < reader.FieldCount; ++j)
                    item.SubItems.Add(reader[j].ToString().Replace(',', '.'));
            }
        }
    }
}

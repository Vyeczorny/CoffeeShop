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

            updateListView();
        }
        
        private void updateListView()
        {
            listView1.Items.Clear();
            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT p.kod_prod, p.nazwa, d.max_ilosc, d.cena_hurt FROM produkt p join dostawca_dostarcza_produkt d using(kod_prod) WHERE kod_dost=" + supplierIdTextBox.Text);

            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add(reader[0].ToString());
                for (int j = 1; j < reader.FieldCount; ++j)
                    item.SubItems.Add(reader[j].ToString().Replace(',', '.'));
            }

            listView1.Refresh();
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            SupplierProductForm window = new SupplierProductForm(supplierIdTextBox.Text);
            window.ShowDialog();

            updateListView();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            PostgreSQL.executeCommand("UPDATE dostawca SET "
                + "nazwa='" + supplierNameTextBox.Text + "',"
                + "nr_konta=" + supplierAccountTextBox.Text
                + "WHERE kod_dost=" + supplierIdTextBox.Text
                );

            this.Close();
        }

        private void removeProductButton_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                PostgreSQL.executeCommand("DELETE FROM dostawca_dostarcza_produkt WHERE "
                    + "kod_dost=" + supplierIdTextBox.Text
                    + " AND kod_prod=" + item.SubItems[0].Text);
                updateListView();
            }
        }
    }
}

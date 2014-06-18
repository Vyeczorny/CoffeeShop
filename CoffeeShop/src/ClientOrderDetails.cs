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
    public partial class ClientOrderDetails : ClientOrder
    {
        public ClientOrderDetails(ListViewItem item)
        {
            orderId =int.Parse(item.SubItems[0].Text);
            oldStatus = item.SubItems[3].Text;
            InitializeComponent();

            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT * FROM uzytkownik WHERE kod_uz=" + item.SubItems[1].Text);
            while (reader.Read())
                clientComboBox.Items.Add(reader[0] + ". " + reader[1] + " " + reader[2]);
            clientComboBox.SelectedIndex = 0;
            clientComboBox.Enabled = false;

            priceTextBox.Text = item.SubItems[2].Text;
            
            string status = item.SubItems[3].Text;
            if (status == "Nowe")
            {
                statusComboBox.Items.Add("Nowe");
                statusComboBox.Items.Add("Oplacone");
                statusComboBox.Items.Add("Skompletowane");
                statusComboBox.Items.Add("Wyslane");
            }
            else if (status == "Oplacone")
            {
                statusComboBox.Items.Add("Oplacone");
                statusComboBox.Items.Add("Skompletowane");
                statusComboBox.Items.Add("Wyslane");
            }
            else if (status == "Skompletowane")
            {
                statusComboBox.Items.Add("Skompletowane");
                statusComboBox.Items.Add("Wyslane");
            }
            else
                statusComboBox.Items.Add("Wyslane");
            statusComboBox.SelectedIndex = 0;

            reader = PostgreSQL.executeCommand("SELECT p.kod_prod, p.nazwa, z.ilosc, p.cena FROM zamowienie_detaliczne_zawiera_produkt z "
                + "JOIN produkt p USING(kod_prod) "
                + "WHERE nr_zamowienia=" + orderId
                );
            while(reader.Read())
            {
                ListViewItem i = listView1.Items.Add(new ListViewItem(reader[0].ToString()));
                i.SubItems.Add(reader[1].ToString());
                i.SubItems.Add(reader[2].ToString());
                i.SubItems.Add(((int)reader[2] * (double)reader[3]).ToString());
            }

            addButton.Hide();
        }

        protected override void okButton_Click(object sender, EventArgs e)
        {
            string newStatus = statusComboBox.Text;
            if (newStatus == "Opłacone")
                newStatus = "Oplacone";
            else if (newStatus == "Wysłane")
                newStatus = "Wyslane";

            if(newStatus == "Skompletowane" || newStatus == "Wyslane")
            {
                if (haveEnoughProducts())
                {
                    foreach (ListViewItem i in listView1.Items)
                        PostgreSQL.executeCommand("UPDATE produkt SET ilosc=ilosc-" + i.SubItems[2].Text + " WHERE kod_prod=" + i.SubItems[0].Text);
                    PostgreSQL.executeCommand("UPDATE zamowienie_detaliczne SET status='" + newStatus + "' WHERE nr_zamowienia=" + orderId);
                    this.Close();
                }
                else
                    MessageBox.Show("W magazynie nie ma wystarczającej ilości produktów");
            }
            else
            {
                PostgreSQL.executeCommand("UPDATE zamowienie_detaliczne SET status='" + newStatus + "' WHERE nr_zamowienia=" + orderId);
                this.Close();
            }
        }

        private bool haveEnoughProducts()
        {
            foreach(ListViewItem item in listView1.Items)
            {
                int noOfProducts = (int)PostgreSQL.executeScalar("SELECT ilosc FROM produkt WHERE kod_prod=" + item.SubItems[0].Text);
                if (noOfProducts < int.Parse(item.SubItems[2].Text))
                    return false;
            }
            return true;
        }

        protected override void addButton_Click(object sender, EventArgs e){}
        protected override void statusComboBox_SelectedIndexChanged(object sender, EventArgs e){}

        private string oldStatus;
        private int orderId;
    }
}

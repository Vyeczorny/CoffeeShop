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
    public partial class DeliveryOrder_Details : DeliveryOrder
    {
        public DeliveryOrder_Details(ListViewItem order)
        {
            orderId = int.Parse(order.SubItems[0].Text);
            oldStatus = order.SubItems[3].Text;

            supplierComboBox.Items.Add(order.SubItems[1].Text + ". " 
                + PostgreSQL.executeScalar("SELECT nazwa FROM dostawca WHERE kod_dost=" + order.SubItems[1].Text));
            supplierComboBox.Enabled = false;
            supplierComboBox.SelectedIndex = 0;

            priceTextBox.Text = order.SubItems[2].Text;
            priceTextBox.Enabled = false;

            string status = order.SubItems[3].Text;
            if(status == "Nowe")
            {
                statusComboBox.Items.Add("Nowe");
                statusComboBox.Items.Add("Opłacone");
                statusComboBox.Items.Add("Otrzymane");
            }
            else if(status == "Oplacone")
            {
                statusComboBox.Items.Add("Opłacone");
                statusComboBox.Items.Add("Otrzymane");
            }
            else
            {
                statusComboBox.Items.Add("Otrzymane");
            }
            statusComboBox.SelectedIndex = 0;

            NpgsqlDataReader reader = PostgreSQL.executeCommand("SELECT kod_prod, nazwa, z.ilosc, d.cena_hurt " 
                + "FROM zamowienie_dostawy_zawiera_produkt z " 
                + "JOIN produkt p USING(kod_prod) "
                + "JOIN dostawca_dostarcza_produkt d USING(kod_prod) "
                + "WHERE nr_zamowienia=" + order.SubItems[0].Text + " "
                + "AND kod_dost=" + order.SubItems[1].Text
                );

            while (reader.Read())
            {
                ListViewItem item = listView1.Items.Add(new ListViewItem(reader[0].ToString()));
                item.SubItems.Add(reader[1].ToString());
                item.SubItems.Add(reader[2].ToString());
                item.SubItems.Add(((int)reader[2] * (double)reader[3]).ToString());
            }

            addButton.Hide();
        }

        protected override void supplierComboBox_SelectedIndexChanged(object sender, EventArgs e) {}
        protected override void addButton_Click(object sender, EventArgs e){}

        protected override void okButton_Click(object sender, EventArgs e)
        {
            string newStatus;
            if (statusComboBox.Text == "Opłacone")
                newStatus = "Oplacone";
            else
                newStatus = statusComboBox.Text;
            PostgreSQL.executeCommand("UPDATE zamowienie_dostawy SET status='" + newStatus + "' WHERE nr_zamowienia=" + orderId);

            if(newStatus == "Otrzymane" && oldStatus != "Otrzymane")
                foreach (ListViewItem item in listView1.Items)
                    PostgreSQL.executeCommand("UPDATE produkt SET ilosc=ilosc+" + item.SubItems[2].Text + " WHERE kod_prod=" + item.SubItems[0].Text);

            this.Close();
        }

        private int orderId;
        private string oldStatus;
    }
}

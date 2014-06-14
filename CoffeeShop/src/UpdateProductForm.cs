using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class UpdateProductForm : ProductForm
    {
        public UpdateProductForm(ListViewItem i)
        {
            item = i;

            nameBox.Text = item.SubItems[3].Text;
            describeBox.Text = item.SubItems[2].Text;
            priceBox.Text = item.SubItems[1].Text;
            countBox.Text = item.SubItems[4].Text;
        }

        public override void updateProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                PostgreSQL.executeCommand("UPDATE produkt SET "
                    + "cena=" + float.Parse(priceBox.Text.Replace(',', '.')) + ","
                    + "opis='" + describeBox.Text + "',"
                    + "nazwa='" + nameBox.Text + "',"
                    + "ilosc=" + int.Parse(countBox.Text) + " "
                    + "WHERE kod_prod=" + item.SubItems[0].Text
                    );
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message + "\n");
            }
        }
    }
}

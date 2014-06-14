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
    public partial class AddProductForm : ProductForm
    {
         public override void updateProductButton_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {

                PostgreSQL.executeCommand("INSERT INTO produkt(cena, opis, nazwa, ilosc) VALUES ("
                    + float.Parse(priceBox.Text.Replace(',', '.')) + ","
                    + "'" + describeBox.Text + "',"
                    + "'" + nameBox.Text + "',"
                    + int.Parse(countBox.Text) + ")"
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

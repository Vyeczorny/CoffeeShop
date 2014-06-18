using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            CultureInfo myCulture = (CultureInfo)Application.CurrentCulture.Clone();
            myCulture.NumberFormat.NumberDecimalSeparator = ".";
            myCulture.NumberFormat.NumberDecimalDigits = 2;

            Thread.CurrentThread.CurrentCulture = myCulture;
            Thread.CurrentThread.CurrentUICulture = myCulture;
            //Application.CurrentCulture.NumberFormat.NumberDecimalSeparator = ".";
            
            PostgreSQL.connect("shop", "localhost", "postgres", "qwe");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AdminWindow());
            //Application.Run(new DeliveryOrder_AddProductWindow(1, null));

            PostgreSQL.close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIMBAM_Project
{
    public class Menu
    {
        public String name { get; set ; }

        public int price { get; set; }

        public int TotalPrice { get; set; }
    
        public String path { get; set; }

        public int count { get; set; }

        public String category { get; set; }

        public String barcode { get; set; }

        public Menu(String name, int price, String category, int count , String barcode)
        {
            this.name = name;
            this.price = price;
            this.category = category;
            this.path = AppDomain.CurrentDomain.BaseDirectory + @"..\..\img\" + this.category + @"\" + this.name + ".jpg";
            this.count = count;
            this.TotalPrice = count * price;
            this.barcode = barcode;
        }


    }
}

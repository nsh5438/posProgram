using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KIMBAM_Project
{
    public class Table
    {
        public List<Menu> MenuInfo { get; set; }

        public String TableNumber { get; set; }

        public String OrderDateTime { get; set; }

        public String PaymentMethod { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafe_management
{
    class mycafeuser
    {
        public int id { get; set; }
        public string username { get; set; }
        public string  mailid { get; set; }
        public long ph_number { get; set; }
        public string password { get; set; }

    }
    class mycafeitems 
    {
        public int item_number { get; set; }
        public string item_name { get; set; }
        public string item_category { get; set; }
        public float item_price { get; set; }
    }
}

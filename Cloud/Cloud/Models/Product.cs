using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cloud.Models
{
    public class Product
    {
        public int id { get; set; }
        public string item_descr_and_name { get; set; }
        public string item_price { get; set; }
        //public IFormFile item_image { get; set; }
        public string ImagePath { get; set; }
    }
}

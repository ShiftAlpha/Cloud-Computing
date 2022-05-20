//Item model to show item properties
//Adds new item details 
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABCTask2
{
    public class Item : TableEntity
    {
        public Item(String pk, String rk)
        {
            //Department
            this.PartitionKey = pk;

            //ItemName
            this.RowKey = rk;
        }

        public Item()
        {

        }
        [Required(ErrorMessage = "Item Name is required!")]
        public String ItemName { get; set; }
        public String ImgURL { get; set; }
        public String Description { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:0.00}")]
        [Required(ErrorMessage = "A Price between R 00.01 - R 9 999 999.99 is required!")]
        [RegularExpression(@"^\d+(.\d{1,2})?$", ErrorMessage = "A Price between R 00.01 - R 9 999 999.99 is required!")]
        [Range(0.01, 9999999.99, ErrorMessage = "A Price between R 00.01 - R 9 999 999.99 is required!")]
        public Double Price { get; set; }

    }
}
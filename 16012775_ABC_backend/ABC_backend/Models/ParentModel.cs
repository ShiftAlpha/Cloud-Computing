using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABCTask2
{
    public class ParentModel
    {
        public Item Item { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
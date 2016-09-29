using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheFirstKick.Models
{
    public class Category
    {
        public int Categoryid { get; set; }
        public string CategoryName { get; set; }

        //Virtual : have been added to apply the lazy loading !
        public virtual List<InventoryItem> InventoryItems { get; set; }
    }
}
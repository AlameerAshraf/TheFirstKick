using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheFirstKick.Models
{
    public class InventoryItem
    {
        public int InventoryItemid { get; set; }
        public string InventoryItemCode { get; set; }
        public string InventoryItemName { get; set; }
        public decimal UnitPrice { get; set; }
        // public Category Category { get; set; }
        public int Categoryid { get; set; }
    }
}
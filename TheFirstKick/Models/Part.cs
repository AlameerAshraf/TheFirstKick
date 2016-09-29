using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace TheFirstKick.Models
{
    public class Part
    {
        public int Partid { get; set; }
        public int WorkOrderId { get; set; }
        //  public workorder WorkOrder { get; set; }
        public string InventoryItemCode { get; set; }
        public string InventoryItemName { get; set; }
        public int Quentity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal ExtendedPrice { get; set; }
        public string Notes { get; set; }
        public bool IsInstalled { get; set; }

    }
}
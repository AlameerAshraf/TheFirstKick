using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheFirstKick.Models
{
    public class WorkOrder
    {
        public int WorkOrderId { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDateTime { get; set; }
        //nullable DateTime : it is not allowed to assign a null value to DateTime DateTime? => is nullable ! 
        public DateTime? TargetDateTime { get; set; }
        public DateTime? DrfopDeadDateTime { get; set; }
        public string Description { get; set; }
        public WorkOrderStatus WorkOrderStatus { get; set; }
        public decimal Total { get; set; }
        public string CertificationRequierments { get; set; }
        public string ReworkNotes { get; set; }
    }

    public enum WorkOrderStatus
    {
        Created =0,
        InProgress=10,
        Rework=15,
        Submitted=20,
        Approved=30,
        Canceled=-10,
        Rejected = -20
    }
}
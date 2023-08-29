using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
    public class ItemRepair
    {
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string? Status { get; set; }
        public virtual Order? RepairOrder { get; set; }
        public int RepairOrderId { get; set; }
    }

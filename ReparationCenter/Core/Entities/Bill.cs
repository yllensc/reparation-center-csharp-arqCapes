using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Bill
    {
        
        public int RepairOrderId { get; set; }
        public decimal Total { get; set; }
        public DateTime Date { get; set; }
        public virtual Order? RepairOrder { get; set; }
    }

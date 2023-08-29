using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
    public class OrderEmployee
    {
        public string? ProblemDescription { get; set; }
        public DateTime Date { get; set; }
        public int RepairOrderId { get; set; }
        public virtual Order? RepairOrder { get; set; }
        public int EmployeeId { get; set; }
        public virtual Employee? Employee { get; set; }

    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
    public class Order
    {
        //public string? NumOrder { get; set; }
        public DateTime DateOrder { get; set; }
        public string? NumPlate { get; set; }
        public string? Km { get; set; }
        public string? Report { get; set; }
        public string? Status { get; set; }
        public int CustomerId { get; set; }
        public virtual Client? Client { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public virtual ICollection<OrderEmployee>? OrderEmployees { get; set; }
        public virtual ICollection<ItemRepair>? ItemRepairs { get; set; }
        public virtual Bill? Bill { get; set; }
    }

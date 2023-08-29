using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Client : BaseEntity
    {
        public DateTime DateRegister { get; set; }
        public string? Email { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public virtual ICollection<Vehicle>? Vehicles { get; set; }
        public virtual ICollection<Order>? Orders { get; set; }

    }

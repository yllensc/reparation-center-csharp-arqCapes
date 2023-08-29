using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Employee : BaseEntity
    {
        public string? Specialty { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
    }

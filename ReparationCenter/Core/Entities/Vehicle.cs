using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
    public class Vehicle
    {
        public string? SerialNumber { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public int Year { get; set; }
        // Vehicle relations
        public int CustomerId { get; set; }
        public virtual Client? Client { get; set; }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
    public class User : BaseEntity
    {
        
        public string? IdentificationDocument { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public long PhoneNumber { get; set; }
        public virtual ICollection<Client>? Clients { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; }




    }

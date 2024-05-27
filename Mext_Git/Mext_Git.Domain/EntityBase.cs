using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mext_Git.Domain
{
    public class EntityBase
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
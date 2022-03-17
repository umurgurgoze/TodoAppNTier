using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppNTier.Entities.Domains
{
    public class Work
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public bool IsComplete { get; set; }
    }
}

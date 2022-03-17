using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppNTier.Dtos.WorkDtos
{
    public class WorkCreateDto
    {
        //Ekleme işlemi yaparken Id değerine ihtiyaç duymadığımızdan Dto'ya eklemiyoruz.
        public string Definition { get; set; }
        public bool IsComplete { get; set; }
    }
}

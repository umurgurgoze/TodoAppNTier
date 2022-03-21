﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppNTier.Dtos.Interfaces;

namespace ToDoAppNTier.Dtos.WorkDtos
{
    public class WorkCreateDto : IDto
    {
        //Ekleme işlemi yaparken Id değerine ihtiyaç duymadığımızdan Dto'ya eklemiyoruz.
        //[Required(ErrorMessage ="Definition is required")]
        public string Definition { get; set; }
        public bool IsComplete { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppNTier.Dtos.WorkDtos
{
    public class WorkUpdateDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public bool IsComplete { get; set; }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Course
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string Description { get; set; }
    }
}

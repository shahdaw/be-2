﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS1
{

    public abstract class AbstractPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public abstract void DisplayInfo();
    }

}

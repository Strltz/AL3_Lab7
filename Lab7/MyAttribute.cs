﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class MyAttribute : Attribute
    {
        public string Comment { get; }
        public MyAttribute() { }
        public MyAttribute(string comment)
        {
            Comment = comment;
        }
    }
}

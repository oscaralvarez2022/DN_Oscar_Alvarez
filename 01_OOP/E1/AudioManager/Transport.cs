﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AudioManager
{
    public class Transport
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Base Class");
        }
    }
}
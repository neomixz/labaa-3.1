using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace labaa_2._3_1_
{
    class RAM1
    {
        public string Name = "Kingston FURY Beast DDR5";
        public int Memory_GB;
        public override string ToString()
        {
            return Name;
        }
        public override int GetHashCode()
        {
            return Memory_GB.GetHashCode();
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace labaa_2._3_1_
{
    class RAM2
    {
        public string Name = "Kingston FURY Beast DDR5";
        public int Memory_GB;
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            RAM2 ram = obj as RAM2;
            if (ram == null) //if(ram as RAM2 == null) - це ідентичні умови??????
                return false;
            return ram.Memory_GB == this.Memory_GB;
        }
        public override int GetHashCode()
        {
            return Memory_GB.GetHashCode();
        }
    }
}

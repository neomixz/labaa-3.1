using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace labaa_2._3_1_
{
    class CPU
    {
        public string Name = "Intel Core i9-12900K";
        public int Cores_Count;
        public override int GetHashCode()
        {
            return Cores_Count.GetHashCode();
        }
    }
}

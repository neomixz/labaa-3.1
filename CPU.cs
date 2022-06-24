using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_1_ReWrite_1_
{
    class CPU
    {
        public string Name { get; set; }
        public string Cores { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            CPU cpu = obj as CPU;
            if (cpu == null)
                return false;

            return cpu.Cores == this.Cores;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override string ToString()
        {
            return Cores.ToString();
        }
    }
}

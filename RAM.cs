using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_1_ReWrite_1_
{
    class RAM
    {
        public string Name { get; set; }
        public string GB { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            RAM ram = obj as RAM;
            if (ram == null)
                return false;

            return ram.GB == this.GB;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override string ToString()
        {
            return GB.ToString();
        }
    }
}

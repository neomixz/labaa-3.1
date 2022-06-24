using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_1_ReWrite_1_
{
    class DRIVE
    {
        public string Name { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            DRIVE drive = obj as DRIVE;
            if (drive == null)
                return false;

            return drive.Name == this.Name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
        public override string ToString()
        {
            return Name.ToString();
        }
    }
}

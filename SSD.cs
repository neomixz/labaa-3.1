using System;
using System.IO;
using System.Linq;

namespace labaa_2._3_1_ReWrite_1_
{
    class SSD
    {
        public string Name { get; set; }
        public string GB { get; set; }

        public string Virus_Cheking()
        {
            int n = 0;
            string path = @"D:\programing\labaa 2.3(1)ReWrite(1)\SSD_data.txt";
            var data = File.ReadAllText(path).Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] == "#VIRUS")
                {
                    data.RemoveAt(i);
                    i--;
                    n++;
                }

            }
            //#VIRUS
            File.WriteAllText(path, string.Join(" ", data));

            return $"There's found and deleted ({n}) viruses!!!";
            
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            SSD ssd = obj as SSD;
            if (ssd == null)
                return false;

            return ssd.GB == this.GB;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace labaa_2._3_1_ReWrite_1_
{
    class Computer
    {
        public CPU cpu { get; set; }
        public SSD ssd { get; set; }
        public RAM ram { get; set; }
        public DRIVE drive { get; set; }

        private string[] PC_Components = { "0", "0", "0", "0" };

        public string[] PC_Creating(string component)
        {
            string info = "";

            switch (component)
            {
                case "CPU":
                    info = $"{component}: {cpu.Name}({cpu.Cores} cores)";
                    break;
                case "SSD":
                    info = $"{component}: {ssd.Name}({ssd.GB}GB)";
                    break;
                case "RAM":
                    info = $"{component}: {ram.Name}({ram.GB}GB)";
                    break;
                case "DRIVE":
                    info = $"{component}: {drive.Name}";
                    break;
            }

            for (int i = 0; i < PC_Components.Length; i++)
            {
                if (PC_Components[i] == "0")
                {
                    PC_Components[i] = info;
                    break;
                }   
            }

            return PC_Components;
        }



    }
}

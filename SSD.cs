using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace labaa_2._3_1_
{
    class SSD
    {
        string Name = "Crucial BX500 2 TB";
        int Memory_GB = 2000;
        public void SSD_Size()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"SSD ({Name}) size : {Memory_GB}GB");
            Console.ResetColor();
        }

        public void Virus_Cheking()
        {
            int n = 0;
            string path = @"D:\programing\labaa 2.3(1)\SSD_data.txt";
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"There's found and deleted ({n}) viruses!!!");
            Console.ResetColor();
        }
    }
}

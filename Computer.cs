using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace labaa_2._3_1_
{
    class Computer
    {
        ConsoleKeyInfo keyInfo;
        List<string> options = new List<string> { "PRESS 1 - checking virusS", "PRESS 2 - SSD' memory", "PRESS 3 - Sleep Mode" };
        int ppoint;
        List<string> options1 = new List<string> { "Turn On", "Turn Off" };

        #region Computer_Methods //Equels_GetHashCode_ToString

         void Sleep_Mode() //Equels_GetHashCode_ToString
        {
            int m = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Computer is in sleep mode!");
                Console.ResetColor();
                Console.WriteLine();


                for (int i = 0; i < options1.Count; i++)
                {
                    if (i == m)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.Write(options1[i] + "\t\t");
                    Console.ResetColor();
                }
                Console.WriteLine();
                keyInfo = Console.ReadKey();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        m--;
                        if (m == -1)
                            m = 1;
                        break;
                    case ConsoleKey.RightArrow:
                        m++;
                        if (m == 2)
                            m = 0;
                        break;

                }
            }
            while (keyInfo.Key != ConsoleKey.Enter);

            if (m == 0)
                Program.Povtor();
            else if (m == 1)
            {
                Console.WriteLine("\n\n");
                var ram1 = new RAM1 { Memory_GB = 16 };
                var ram2 = new RAM2 { Memory_GB = 8 };
                var ram2_2 = new RAM2 { Memory_GB = 16 };
                var cpu = new CPU { Cores_Count = 16 };
                Console.WriteLine($"Method 'ToString' of class 'ram1' : {ram1}");
                Console.WriteLine($"Method 'Equels' of class 'ram2(ram2_2)' : {ram2.Equals(ram2_2)}");
                Console.WriteLine($"Method 'GetHashCose' of classes ram1({ram1.GetHashCode()}) and cpu({cpu.GetHashCode()})");
            }
        }

         void Menu()
        {
            int m = 0;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("PC-IS-ON ");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("MENU");
                for (int i = 0; i < options.Count; i++)
                {
                    if (i == m)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(options[i]);
                    Console.ResetColor();
                }
                keyInfo = Console.ReadKey();
                Console.Clear();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        m++;
                        break;
                    case ConsoleKey.UpArrow:
                        m--;
                        break;
                }
                if (m == 3)
                    m = 0;
                else if (m == -1)
                    m = 2;
            }
            while (keyInfo.Key != ConsoleKey.Enter);
            ppoint = m;
        }
        #endregion
        public Computer(SSD ssd, RAM1 ram, RAM2 ram2, Disk_Drive disk_drive, CPU cpu)
        {
            Menu();
            switch (ppoint)
            {
                case 0:
                    ssd.Virus_Cheking();
                    Console.WriteLine("Press ESCAPE to Exit!");
                    do
                        keyInfo = Console.ReadKey();
                    while (keyInfo.Key != ConsoleKey.Escape);
                    Program.Povtor();
                    break;
                case 1:
                    ssd.SSD_Size();
                    Console.WriteLine("Press ESCAPE to Exit!");
                    do
                        keyInfo = Console.ReadKey();
                    while (keyInfo.Key != ConsoleKey.Escape);
                    Program.Povtor();
                    break;
                case 2:
                    Sleep_Mode();
                    break;
                   
            }
        } //potribni metody
    }
}

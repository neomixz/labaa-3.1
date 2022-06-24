using System;

namespace labaa_2._3_1_ReWrite_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer() { cpu = new CPU(), ssd = new SSD(), ram = new RAM(), drive = new DRIVE() };

            int n = 0;
            string[] components = { "CPU", "SSD", "RAM", "DRIVE" };
            do
            {
                Console.Clear();
                Console.WriteLine("To start PC you must ADD all components!!");                
                Console.WriteLine();
                Console.WriteLine($"LEFT: {string.Join(" ", components)}");
                Console.Write("ADD: ");
                string c = Console.ReadLine();
                
                switch (c)
                {
                    case "CPU":
                        Console.Write($"Name: ");
                        computer.cpu.Name = Console.ReadLine();
                        Console.Write($"Cores: ");
                        computer.cpu.Cores = Console.ReadLine();
                        break;
                    case "SSD":
                        Console.Write($"Name: ");
                        computer.ssd.Name = Console.ReadLine();
                        Console.Write($"GB: ");
                        computer.ssd.GB = Console.ReadLine();
                        break;
                    case "RAM":
                        Console.Write($"Name: ");
                        computer.ram.Name = Console.ReadLine();
                        Console.Write($"GB: ");
                        computer.ram.GB = Console.ReadLine();
                        break;
                    case "DRIVE":
                        Console.Write($"Name: ");
                        computer.drive.Name = Console.ReadLine();   
                        break;
                }
            
            
            
                for (int i = 0; i < components.Length; i++)
                {
                    if (c == components[i])
                    {
                        components[i] = "0";
                        Console.WriteLine();
                        Console.WriteLine("Your PC:");
                        foreach (var item in computer.PC_Creating(c))
                            Console.WriteLine(item);                       
                        Console.ReadLine();
                    }
                }
            
                       
                n = 0;
                foreach (var item in components) //CHECK
                {
                    if (item == "0")
                        n++;
                }
            }
            while (n != 4);
            
            Console.WriteLine("\n");
            Console.WriteLine("PC'S CREATED!!");
            Console.ReadLine();



            int e = 0;
            
            do
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("OPTIONS: 1. Checking virusS | 2.SDD Memory | 3.Turn Off");
            
                string option = Console.ReadLine();
            
                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(computer.ssd.Virus_Cheking());
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine($"SSD's memory size: {computer.ssd.GB}");
                        Console.ReadLine();
                        break;
                    case "3":
                        e = 1;
                        Console.Clear();                        
                        break;
                }
            }
            while (e != 1);
        }

    }
}

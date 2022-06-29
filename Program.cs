using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace labaa_2._3_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Створити об'єкт класу Комп'ютер, використовуючи класи Вінчестер, Дисковод,
            //Оперативна пам'ять, Процесор. Методи: включити, вимкнути, перевірити на віруси,
            //вивести на консоль розмір вінчестера.

            ConsoleKeyInfo keyInfo;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TO START PC PRESS ENTER!");
                keyInfo = Console.ReadKey();
                Console.ResetColor();
            }
            while (keyInfo.Key != ConsoleKey.Enter);

            Povtor();

        }
        static public void Povtor()
        {
            new Computer(new SSD(), new RAM1(), new RAM2(), new Disk_Drive(), new CPU());
        }
    }
}

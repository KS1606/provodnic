using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace проводник
{
    internal class provodnik
    {
        public static void Base()
        {
            Base1();
        }
        private static void Base1()
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Этот компьютер");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            DriveInfo[] alldrives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in alldrives)
            {
                float freely = (((drive.AvailableFreeSpace / 1024) / 1024) / 1024);
                float total = ((((drive.TotalSize) / 1024) / 1024) / 1024);
                Console.WriteLine("   " + drive.Name + freely + " ГБ свободно" + " из " + total + " ГБ");
            }
            Strelk();
        }
        private static void  Strelk()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {
                int position = 3;
                while (key.Key != ConsoleKey.Enter)
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }
                    int max = position + 1;
                    int min = position - 1;
                    Console.SetCursorPosition(0, max);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, min);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                }
                if (position == 2)
                {
                    DiskC();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Base1();
                    }
                }
                if (position == 3)
                {
                    DiskD();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        Base1();
                    }
                }
                if(position == 7)
                {
                    Vvod();
                }
                if (position == 12)
                {
                    Vvod1();
                }
                if (position == 15)
                {
                    Vvod2();
                }
                if (position == 16)
                {
                    Vvod3();
                }
                if (position == 18)
                {
                    Vvod4();
                }
                if (position == 20)
                {
                    Vvod5();
                }
                if (position == 22)
                {
                    Vvod9();
                }
                if (position == 23)
                {
                    Vvod6();
                }
                if (position == 24)
                {
                    Vvod7();
                }
                if (position == 25)
                {
                    Vvod8();
                }
                
            }
        }
        private static void Strelk1()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {
                int position = 3;
                while (key.Key != ConsoleKey.Enter)
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }
                    int max = position + 1;
                    int min = position - 1;
                    Console.SetCursorPosition(0, max);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, min);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        DiskC();
                    }
                }
                
            }
        }
        private static void Strelk2()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {
                int position = 3;
                while (key.Key != ConsoleKey.Enter)
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }
                    int max = position + 1;
                    int min = position - 1;
                    Console.SetCursorPosition(0, max);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, min);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                }

            }
        }
        private static void DiskC()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\");
            Papki();
            int date = 4;
            foreach (var item in dir.GetDirectories())
            {
                date = date + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date);
                Console.WriteLine(item.CreationTime);
            }
            int date1 = 24;
            foreach (var item in dir.GetFiles())
            {
                date1 = date1 + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date1);
                Console.WriteLine(item.CreationTime);
            }
            Strelk();
        }
        private static void DiskD()
        {
            Console.Clear();
            DirectoryInfo dir1 = new DirectoryInfo(@"D:\");
            int date3 = 4;
            int date4 = 7;
            Papki();
            foreach (var item in dir1.GetDirectories())
            {
                date3 = date3 + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date3);
                Console.WriteLine(item.CreationTime);
            }
            foreach (var item in dir1.GetFiles())
            {
                date4 = date4 + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date4);
                Console.WriteLine(item.CreationTime);
            }
            Strelk2();
        }
        private static void Papki()
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine(" Папки");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("                                                                                                                        ");
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("Дата изменения");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("   Название");
            Console.WriteLine("                                                                                                                        ");
        }
        private static void Vvod()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\$WINDOWS.~BT");
            Papki();
            int date = 4;
            foreach (var item in dir.GetDirectories())
            {
                date = date + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk1();
        }
        private static void Vvod1()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Intel");
            Papki();
            int date = 4;
            foreach (var item in dir.GetDirectories())
            {
                date = date + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk1();
        }
        private static void Vvod2()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Program Files");
            Papki();
            int date = 4;
            foreach (var item in dir.GetDirectories())
            {
                date = date + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk1();
        }
        private static void Vvod3()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Program Files (x86)");
            Papki();
            int date = 4;
            foreach (var item in dir.GetDirectories())
            {
                date = date + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk1();
        }
        private static void Vvod4()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Recovered Files");
            Papki();
            int date = 4;
            foreach (var item in dir.GetDirectories())
            {
                date = date + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date);
                Console.WriteLine(item.CreationTime);
            }
            int date1 = 5;
            foreach (var item in dir.GetFiles())
            {
                date1 = date1 + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date1);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk1();
        }
        private static void Vvod5()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\recycler");
            Papki();
            int date = 4;
            foreach (var item in dir.GetDirectories())
            {
                date = date + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk1();
        }
        private static void Vvod6()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");
            Papki();
            int date = 4;
            foreach (var item in dir.GetDirectories())
            {
                date = date + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date);
                Console.WriteLine(item.CreationTime);
            }
            int date1 = 78;
            foreach (var item in dir.GetFiles())
            {
                date1 = date1 + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date1);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk1();
        }
        private static void Vvod7()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Новая папка");
            Papki();
            int date1 = 4;
            foreach (var item in dir.GetFiles())
            {
                date1 = date1 + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date1);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk3();
        }
        private static void Vvod8()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Новая папка (2)");
            Papki();
            int date1 = 4;
            foreach (var item in dir.GetFiles())
            {
                date1 = date1 + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date1);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk4();
        }
        private static void Vvod9()
        {
            Console.Clear();
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users");
            Papki();
            int date = 4;
            foreach (var item in dir.GetDirectories())
            {
                date = date + 1;
                Console.WriteLine("   " + item.Name);
                Console.SetCursorPosition(50, date);
                Console.WriteLine(item.CreationTime);
            }
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                DiskC();
            }
            Strelk1();
        }
        private static void Strelk3()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {
                int position = 3;
                while (key.Key != ConsoleKey.Enter)
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }
                    int max = position + 1;
                    int min = position - 1;
                    Console.SetCursorPosition(0, max);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, min);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        DiskC();
                    }
                }
                if (position == 5)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Новая папка\\Document (1).docx", UseShellExecute = true });
                    Vvod7();
                }
                if (position == 6)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Новая папка\\ПППППППППППП.xlsx", UseShellExecute = true });
                    Vvod7();
                }
            }
        }
        private static void Strelk4()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {
                int position = 3;
                while (key.Key != ConsoleKey.Enter)
                {
                    if (key.Key == ConsoleKey.UpArrow)
                    {
                        position--;
                    }
                    if (key.Key == ConsoleKey.DownArrow)
                    {
                        position++;
                    }
                    int max = position + 1;
                    int min = position - 1;
                    Console.SetCursorPosition(0, max);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, min);
                    Console.WriteLine("   ");
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                    key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Escape)
                    {
                        DiskC();
                    }
                }
                if (position == 5)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Новая папка (2)\\Benefits of using AI systems.pptx", UseShellExecute = true });
                    Vvod8();
                }
                if (position == 6)
                {
                    Process.Start(new ProcessStartInfo { FileName = "C:\\Новая папка (2)\\Document.docx", UseShellExecute = true });
                    Vvod8();
                }
            }
        }
    }
}

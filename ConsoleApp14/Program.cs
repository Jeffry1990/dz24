using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите любой день недели или exit чтобы завершить");

            string day = Console.ReadLine();

            switch (day)
            {
                case "понедельник":
                case "вторник":
                case "среда":
                case "четверг":
                case "пятница":
                case "суббота":
                case "воскресенье":
                    Console.WriteLine("день недели");
                    break;
                case "exit":
                    while (day == "exit")
                    {
                        Console.WriteLine("Выход из программы");
                        break;
                    }
                        break;
                default:
                    Console.WriteLine("Я такого дня недели не знаю");
                    break;
            }
        }
        }
    }
    


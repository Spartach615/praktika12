using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika12
{
    internal class Program
    {
        //ЗАДАНИЕ 1
        class Calculator
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }

            public static double Subtract(double a, double b)
            {
                return a - b;
            }

            public static double Multiply(double a, double b)
            {
                return a * b;
            }

            public static string Divide(double a, double b)
            {
                if (b == 0)
                    return "Ошибка: деление на ноль";
                return (a / b).ToString();
            }
        }
        //ЗАДАНИЕ 2
        class ProgramConfig
        {
            private const string version = "1.0.0.0";
            private const string name = "Kirill";

            public static void Info()
            {
                Console.WriteLine($"Версия программы: {version} \nРазработчик: {name}");
            }
        }
        //ЗАДАНИЕ 3
        class ObjectCounter
        {
            private static int counter = 0;
            public ObjectCounter()
            {
                counter++;
            }
            public static void Counter()
            {
                Console.WriteLine($"Количество объектов: {counter.ToString()}");
            }
        }
        //ЗАДАНИЕ 4
        class Book
        {
            public readonly string ISBN;
            private string title;
            private string auhtor;

            public string Title
            {
                get { return title; }
                set { title = value; }
            }
            public string Auhtor
            {
                get { return auhtor; }
                set { auhtor = value; }
            }
            public Book()
            {
                this.ISBN = "978-5-00118-187-3";
            }
            public void Info()
            {
                Console.WriteLine($"Автор: {Auhtor},произведение: {Title},ISBN: {ISBN}");
            }
        }
        //ЗАДАНИЕ 5 
        class Settings
        {
            private static readonly string pathtofile;

            static Settings()
            {
                pathtofile = "C:\\Users\\User\\source\\repos\\Praktika12\\";
            }

            public static void Pathtofile()
            {
                Console.WriteLine($"Путь к файлу конфигурации: " + pathtofile);
            }
        } 
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(100000, 132412));       
            Console.WriteLine(Calculator.Subtract(3214, 232345)); 
            Console.WriteLine(Calculator.Multiply(244235, 98765456));  
            Console.WriteLine(Calculator.Divide(435454, 0));
            Console.WriteLine();

            ProgramConfig.Info();
            Console.WriteLine();

            ObjectCounter obj1 = new ObjectCounter();
            ObjectCounter obj2 = new ObjectCounter();
            ObjectCounter obj3 = new ObjectCounter();
            ObjectCounter obj4 = new ObjectCounter();
            ObjectCounter obj5 = new ObjectCounter();
            ObjectCounter.Counter();
            Console.WriteLine();

            Book book = new Book();
            book.Auhtor = "Гета, М.Р.";
            book.Title = "Коррупция: причины, проявления, противодействие";
            book.Info();
            Console.WriteLine();

            Settings.Pathtofile();

        }
    }
}

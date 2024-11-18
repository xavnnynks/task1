using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace task1
{
    internal class Program
    {
        static void first()
        {
            Console.WriteLine("Enter the First number:");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second number:");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Third number:");
            double w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Four number:");
            double s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The average of {x}, {y}, {w}, {s} is {(x + y + w + s) / 4}");
        }

        static void second()
        {
            Console.WriteLine("Введите два числа");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble (Console.ReadLine());
            Console.WriteLine($"\nВы ввели числа: {a} и {b}.\nКакое действие выполнить?\n1. Сложение \n2. Вычитание\n3. Умножение\n4. Деление\n5. Остаток от деления");
            double e = Convert.ToInt32(Console.ReadLine());
            switch(e)
            {
                case 1:
                    Console.WriteLine($"Результат: {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Результат: {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Результат: {a * b}");
                    break;
                case 4:
                    Console.WriteLine($"Результат: {a / b}");
                    break;
                case 5:
                    Console.WriteLine($"Результат: {a % b}");
                    break;
            }
        }

        static void third() 
        {
            double grad;
            Console.WriteLine("Выберите шкалу вводимой температуры:\n1. Цельсий \n2. Кельвин \n3. Фаренгейт");
            double e = Convert.ToInt32(Console.ReadLine());
            switch(e)
            {
                case 1: // ЦЕЛЬСИЙ
                    Console.WriteLine("Введите показатель температура (градусы):");
                    grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Выберите тип шкалы для конвертации:\n1. Цельсий \n2. Кельвин \n3. Фаренгейт");
                    double cl = Convert.ToInt32(Console.ReadLine());
                    switch(cl)
                    {
                        case 1: // ЦЕЛЬСИЙ ЦЕЛЬСИЙ ДУБЛИКАТ
                            Console.WriteLine("Вы выбрали: Цельсий -> Цельсий");
                            Console.WriteLine($"Результат конвертации: {grad}");
                            break;
                        case 2: // ЦЕЛЬСИЙ КЕЛЬВИН
                            Console.WriteLine("Вы выбрали: Цельсий -> Кельвин");
                            Console.WriteLine($"Результат конвертации: {grad + 273.15}");
                            break;
                        case 3: // ЦЕЛЬСИЙ ФАРЕНГЕЙТ
                            Console.WriteLine("Вы выбрали: Цельсий -> Фаренгейт");
                            Console.WriteLine($"Результат конвертации: {(grad * 9 / 5) + 32}");
                            break;
                    }
                    break;
                case 2: // КЕЛЬВИН
                    Console.WriteLine("Введите показатель температура (градусы):");
                    grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Выберите тип шкалы для конвертации:\n1. Цельсий \n2. Кельвин \n3. Фаренгейт");
                    double kelv = Convert.ToInt32(Console.ReadLine());
                    switch (kelv)
                    {
                        case 1: // КЕЛЬВИН ЦЕЛЬСИЙ
                            Console.WriteLine("Вы выбрали: Кельвин -> Цельсий");
                            Console.WriteLine($"Результат конвертации: {grad - 273.15}");
                            break;
                        case 2: // КЕЛЬВИН КЕЛЬВИН ДУБЛИКАТ
                            Console.WriteLine("Вы выбрали: Кельвин -> Кельвин");
                            Console.WriteLine($"Результат конвертации: {grad}");
                            break;
                        case 3: // КЕЛЬВИН ФАРЕНГЕЙТ
                            Console.WriteLine("Вы выбрали: Кельвин -> Фаренгейт");
                            Console.WriteLine($"Результат конвертации: {(grad - 273.15) * 9 / 5 + 32}");
                            break;
                    }
                    break;
                case 3: // ФАРЕНГЕЙТ
                    Console.WriteLine("Введите показатель температура (градусы):");
                    grad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Выберите тип шкалы для конвертации:\n1. Цельсий \n2. Кельвин \n3. Фаренгейт");
                    double far = Convert.ToInt32(Console.ReadLine());
                    switch (far)
                    {
                        case 1: // ФАРЕНГЕЙТ ЦЕЛЬСИЙ
                            Console.WriteLine("Вы выбрали: Фаренгейт -> Цельсий");
                            Console.WriteLine($"Результат конвертации: {(grad - 32) * 5 / 9}");
                            break;
                        case 2: // ФАРЕНГЕЙТ КЕЛЬВИН
                            Console.WriteLine("Вы выбрали: Фаренгейт -> Кельвин");
                            Console.WriteLine($"Результат конвертации: {(grad - 32) * 5 / 9 + 273.15}");
                            break;
                        case 3: // ФАРЕНГЕЙТ ФАРЕНГЕЙТ ДУБЛИКАТ
                            Console.WriteLine("Вы выбрали: Фаренгейт -> Фаренгейт");
                            Console.WriteLine($"Результат конвертации: {grad}");
                            break;
                    }
                    break;
            }

        }
        static void four()
        {
            Console.WriteLine("Введите путь до файла:");
            string s = Console.ReadLine();
            string[] subs = s.Split('/');
            Console.WriteLine($"Имя файла: {subs.Last()}");
        }
       
        static void five()
        {
            Console.WriteLine("Введите предложение:");
            string x = Console.ReadLine();
            string[] xubs = x.Split(' ');
            int maxlen = 0;
            int index = 0;
            for (int i = 0; i < xubs.Length; i++)
            {
                int len = xubs[i].Length;
                if (len > maxlen)
                {
                    maxlen = len;
                    index = i;
                }
            }
            Console.WriteLine($"Самое длинное слово с длинной {maxlen}: {xubs[index]}");
        }

        static void six()
        {
            Console.WriteLine("Введите значения для первого массива через пробел:");
            string x = Console.ReadLine();
            string[] massx = x.Split(' ');

            Console.WriteLine("Введите значения для второго массива через пробел:");
            string y = Console.ReadLine();
            string[] massy = x.Split(' ');

            int a = Convert.ToInt32((string)massx[0]) * Convert.ToInt32((string)massy[0]);
            int b = Convert.ToInt32((string)massx[1]) * Convert.ToInt32((string)massy[1]);
            int c = Convert.ToInt32((string)massx[2]) * Convert.ToInt32((string)massy[2]);
            int d = Convert.ToInt32((string)massx[3]) * Convert.ToInt32((string)massy[3]);

            Console.WriteLine($"Результат: {a} {b} {c} {d}");
        }

        static void seven()
        {
            Console.WriteLine("Введите пять чисел:");
            string x = Console.ReadLine();
            string[] massx = x.Split(' ');
            int max = 0;
            int min = Convert.ToInt32(massx[0]);
            for (int i = 0; i < massx.Length; i++)
            {
                int len = Convert.ToInt32(massx[i]);
                if (len > max)
                {
                    max = len;
                }
                if (len < min)
                {
                    min = len;
                }
            }
            Console.WriteLine($"Максимальное число: {max}");
            Console.WriteLine($"Минимальное число: {min}");
        }

        static void eight()
        {
            Console.WriteLine("Введите количество ступеней:");
            int x = Convert.ToInt32(Console.ReadLine());
            string res = "";
            for (int i = 0; i < x+ 1; i++)
            {
                if (i == 1)
                {
                    res += "1";
                }
                else if (i == 2)
                {
                    res += "2";
                }
                else if (i == 3)
                {
                    res += "3";
                }
                else if (i == 4)
                {
                    res += "4";
                }
                else if (i == 5)
                {
                    res += "5";
                }
                else if (i == 6)
                {
                    res += "6";
                }
                else if (i == 7)
                {
                    res += "7";
                }
                else if (i == 8)
                {
                    res += "8";
                }
                else if (i == 9)
                {
                    res += "9";
                    i = 1;
                }
                Console.WriteLine(res);
            }
        }
        static void nine()
        {
            // Напечатать полную таблицу умножения
            int a = 1;
            int b = 0;

            for (int i = 0; i < 10; i++)
            {
                int res = a * b;
                //string s = $"{a} x {b} = {res}";
                //Console.WriteLine(s);
                Console.WriteLine($"{a} x {b} = {res}");
                b++;
                if (i == 9)
                {
                    if (a < 9)
                    {
                        i = 0;
                        a++;
                        b = 1;
                        /*for (int j = 0; j < 10; j++)
                        {
                            s += $"  {a} x {b} = {res}";
                        }*/
                    }

                }
            }
            
        }

        static void ninne()
        {
            int a = 1;
            int b = 1;
            for (int i = 0; i < 10; i++)
            {
                int res = a * b;
                Console.WriteLine($"{a} x {b} = {res}  {a} x {b} = {res}  {a} x {b} = {res}");
            }
        }

        static void ten() // вариант 18
        {
            for (int a = 20; a <= 900;  a++)
            {
                string s = Convert.ToString(a);
                int first = (int)Char.GetNumericValue(s[0]);
                int second = (int)Char.GetNumericValue(s[1]);
                if (first + second == 7)
                {
                    Console.WriteLine(a);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Укажите номер задания.\n1. среднее \n2. калькулятор \n3. температура \n4. имя файла \n5. длинное слово \n6. два массива \n7. максимальное и минимальное \n8. пирамида \n9. таблица умножения \n10. вариант 18");
            double task = Convert.ToInt32(Console.ReadLine());
            switch(task)
            {
                case 1:
                    Console.Clear();
                    first();
                    break;
                case 2:
                    Console.Clear();
                    second();
                    break;
                case 3:
                    Console.Clear();
                    third();
                    break;
                case 4:
                    Console.Clear();
                    four();
                    break;
                case 5:
                    Console.Clear();
                    five();
                    break;
                case 6:
                    Console.Clear();
                    six();
                    break;
                case 7:
                    Console.Clear();
                    seven();
                    break;
                case 8:
                    Console.Clear();
                    eight();
                    break;
                case 9:
                    Console.Clear();
                    nine();
                    break;
                case 10:
                    Console.Clear();
                    ten();
                    break;
                default:
                    Console.WriteLine("Неверный выбор");
                    break;
            }
            Console.ReadLine();
        }
    }
}

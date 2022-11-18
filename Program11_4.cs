using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myDate = DateTime.Now;//обьявление переменной типа DateTime и присваение значения
            Console.WriteLine("Дата в формате d: {0:d}\nВ формате D: {0:D}", myDate);//вывод на экран сообщения пользователю
            Console.WriteLine("Дата в формате f: {0:f}\nВ формате F: {0:F}", myDate);//вывод на экран сообщения пользователю
            Console.WriteLine("Дата в формате g: {0:g}\nВ формате G: {0:G}", myDate);//вывод на экран сообщения пользователю
            Console.WriteLine("Дата в формате m: {0:m}\nВ формате M: {0:M}", myDate);//вывод на экран сообщения пользователю
            Console.WriteLine("Дата в формате r: {0:r}\nВ формате R: {0:R}", myDate);//вывод на экран сообщения пользователю
            Console.WriteLine("Дата в формате o: {0:o}\nВ формате O: {0:O}", myDate);//вывод на экран сообщения пользователю
            Console.WriteLine("Дата в формате s: {0:s}", myDate);//вывод на экран сообщения пользователю
            Console.WriteLine("Дата в формате t: {0:t}\nВ формате T: {0:T}", myDate);//вывод на экран сообщения пользователю
            Console.WriteLine("Дата в формате u: {0:u}\nВ формате U: {0:U}", myDate);//вывод на экран сообщения пользователю
            Console.WriteLine("Дата в формате y: {0:y}\nВ формате Y: {0:Y}", myDate);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}

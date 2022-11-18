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
            var arr1 = new[] { 1, 2, 3 };//обьявление одномерного массива
            Console.WriteLine("Тип массива arr1 - {0}", arr1.GetType());//вывод на экран сообщения пользователю

            var arr2 = new[] { "One", "Two", "Three" };//обьявление одномерного массива
            Console.WriteLine("Тип массива arr2 - {0}", arr2.GetType());//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}

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
            int[] myArr = { 4, 5, -183, 12, 34, 0, 2, -13 };//обьявление двумерного массива

            Console.WriteLine("Исходный массив чисел: ");//вывод на экран сообщения пользователю
            foreach (int x in myArr)//оператор перебора элементов массива
                Console.Write("\t{0}", x);//вывод на экран сообщения пользователю

            // Реализуем сортировку массива
            Console.WriteLine("\n\nОтсортированный массив:");//вывод на экран сообщения пользователю
            Array.Sort(myArr);//сортирует элементы во всем одномерном массиве
            foreach (int x in myArr)//оператор перебора элементов массива
                Console.Write("\t{0}", x);//вывод на экран сообщения пользователю

            // Организуем поиск числа 12
            Console.WriteLine("\n\nПоиск числа:");//вывод на экран сообщения пользователю
            int search = Array.BinarySearch(myArr, 12);//выполняет поиск заданного элемента во всем отсортированном одномерном массиве
            Console.WriteLine("Число 12 находится на {0} позиции", search + 1);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}

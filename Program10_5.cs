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
            int[][] myArr = new int[3][];//обьявление двумерного массива
            myArr[0] = new int[4];//длина первой строки массива
            myArr[1] = new int[10];//длина второй строки массива
            myArr[2] = new int[1];//длина третьей строки массива

            Console.WriteLine("Общая длина всего массива: " + myArr.Length);//вывод на экран сообщения пользователю
            Console.WriteLine("\nДлина первой цепи: " + myArr[0].Length);//вывод на экран сообщения пользователю
            Console.WriteLine("\nДлина второй цепи: " + myArr[1].Length);//вывод на экран сообщения пользователю
            Console.WriteLine("\nДлина третьей цепи: " + myArr[2].Length);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}

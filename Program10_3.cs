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
            int[] myArr = { 1, 2, 3, 4 };//обьявление одномерного массива

            for (int i = 0; i < myArr.Length; i++)////условный оператор, выполняется пока i < myArr.Length
                Console.WriteLine(myArr[i]);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}

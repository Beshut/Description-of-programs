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
            // Объявляем массив
            int[] myArr = new int[5];

            // Инициализируем каждый элемент массива вручную
            myArr[0] = 100;
            myArr[1] = 23;
            myArr[2] = 25;
            myArr[3] = 31;
            myArr[4] = 1;

            foreach (int i in myArr)//оператор перебора элементов массива
                Console.WriteLine(i);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}

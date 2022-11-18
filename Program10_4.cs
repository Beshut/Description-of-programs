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
            int i = 0;
            // Объявляем ступенчатый массив
            int[][] myArr = new int[4][];
            myArr[0] = new int[4];
            myArr[1] = new int[6];
            myArr[2] = new int[3];
            myArr[3] = new int[4];

            // Инициализируем ступенчатый массив
            for (; i < 4; i++)//условный оператор,выполняется пока i < 4
            {
                myArr[0][i] = i;//присваивание значения элементу массива
                Console.Write("{0}\t", myArr[0][i]);//вывод на экран сообщения пользователю
            }

            Console.WriteLine();//пропуск строки
            for (i = 0; i < 6; i++)//условный оператор,выполняется пока i < 6
            {
                myArr[1][i] = i;//присваивание значения элементу массива
                Console.Write("{0}\t", myArr[1][i]);//вывод на экран сообщения пользователю
            }

            Console.WriteLine();//пропуск строки
            for (i = 0; i < 3; i++)//условный оператор,выполняется пока i < 3
            {
                myArr[2][i] = i;//присваивание значения элементу массива
                Console.Write("{0}\t", myArr[2][i]);//вывод на экран сообщения пользователю
            }

            Console.WriteLine();//пропуск строки
            for (i = 0; i < 4; i++)//условный оператор,выполняется пока i < 4
            {
                myArr[3][i] = i;//присваивание значения элементу массива
                Console.Write("{0}\t", myArr[3][i]);//вывод на экран сообщения пользователю
            }

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}

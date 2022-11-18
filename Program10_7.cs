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
            foreach (string s in myReturn())//оператор перебора элементов массива
                Console.WriteLine(s);//вывод на экран сообщения пользователю
            int[] mySortArray = { 4, 1, 2, 5, 3 };//обьявление одномерного массива

            for (int i = 0; i <= 4; i++)//условный оператор, выполняется пока i <= 4
                mySortArray[i] = mySort(mySortArray, i);//присвоение значения элементу массива, выполнение рекурсивной функции

            Console.WriteLine("\nОтсортированный массив:\n");//вывод на экран сообщения пользователю
            foreach (int i in mySortArray)//оператор перебора элементов массива
                Console.Write("\t" + i);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание  нажатия клавиши
        }

        // Данный метод возвращает массив Info
        static Array myReturn()//обьявление рекурсивной функции
        {
            string[] Info = { "Name", "Family", "Adress" };//обьявление одномерного массива
            return Info;//завершает выполнение метода, возвращает управление и рузультат функции вызывавшему методу
        }

        // Передача массива в метод в качестве параметра
        // Данный метод возвращает значение одного из индексов
        // отсортированного массива
        static int mySort(Array sortArray, int i)//обьявление рекурсивной функции
        {
            Array.Sort(sortArray);//сортирует элементы во всем одномерном массиве
            return (int)sortArray.GetValue(i);//завершает выполнение метода, возвращает управление и рузультат функции вызывавшему методу; возвращает значение, хранящееся в указанной позиции одномерного массива
        }
    }
}

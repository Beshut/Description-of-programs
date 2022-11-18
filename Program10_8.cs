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
            int[] arr1 = { 1, 2, 3, 4, 5, 6 };//обьявление одномерного массива
            int[] arr2 = { 7, 8, 9, 10 };//обьявление одномерного массива

            var mySegmentsArray = new ArraySegment<int>[3]//обьявление одномерного массива
            {
                // Инициализируем сегменты массивов
                new ArraySegment<int>(arr1,0,2),
                new ArraySegment<int>(arr2,0,1),
                new ArraySegment<int>(arr1,1,2)
            };

            Console.WriteLine("Сумма выбранных значений равна:\n" + SumArraySegments(mySegmentsArray));//вывод сообщения на экран пользователю
            Console.ReadLine();//ожидание нажатия клавиши
        }

        // Метод, вычисляющий сумму выбранных сегментов
        static int SumArraySegments(ArraySegment<int>[] value)//обьявление рекурсивной функции
        {
            int sum = 0;//обьявление переменной типа int, присвоение значия "0"
            foreach (var s in value)//оператор перебора элементов массива
                for (int i = s.Offset; i < s.Offset + s.Count; i++)//условный оператор, выполняется пока i < s.Offset + s.Count
                    sum += s.Array[i];//прсваение значения переенной
            return sum;//завершает выполнение метода, возвращает управление и рузультат функции вызывавшему методу
        }
    }
}

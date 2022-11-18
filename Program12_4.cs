using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        enum Days//перечисление переменных
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            HashSet<Days> DaysHashSet = new HashSet<Days>();//обьявление набора значений
            DaysHashSet.Add(Days.Friday);//добавление переменной
            DaysHashSet.Add(Days.Friday);//добавление переменной
            DaysHashSet.Add(Days.Monday);//добавление переменной

            foreach (Days DayItem in DaysHashSet)//оператор перебора элементов массива
                Console.WriteLine(DayItem);//вывод на экран сообщения пользователю

            Console.Write("Press ENTER to continue...");//вывод на экран сообщения пользователю
            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}

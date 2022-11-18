using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = GetNamedValues(new int[] { 1, 2, 3, 4, 5, 6, 7 });//обьявление переменной, применение рекурсивной функции
            Console.WriteLine(tuple.count);//вывод на экран сообщения пользователю
            Console.WriteLine(tuple.sum);//вывод на экран сообщения пользователю

            Console.Read();//ожидание нажатия клавиши
        }
        private static (int sum, int count) GetNamedValues(int[] numbers)//обьявление рекурсивной функции
        {
            var result = (sum: 0, count: 0);//обьявдение переменной
            for (int i = 0; i < numbers.Length; i++)//условный оператор, выполняется пока i < numbers.Length
            {
                result.sum += numbers[i];//присвоение значения переменной
                result.count++;//присвоение значения переменной
            }
            return result;//завершает выполнение метода, возвращает управление и рузультат функции вызывавшему методу
        }
    }
}

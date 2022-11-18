using System;

namespace ConsoleApplication1
{
    class Program
    {
        enum Operation//перечисление переменных
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }

        static void MathOp(double x, double y, Operation op)//обьявление рекурсивной функции 
        {
            double result = 0.0;//обьявление переменной типа double и присвоение значения

            switch (op)//условный оператор, оценивает некоторое выражение и сравнивает его значение с набором значений
            {
                case Operation.Add://условный оператор, в случае ввода в функцию Operation.Add
                    result = x + y;//присвоение результата сложения двух чисел
                    break;//завершение выполнение блока команд
                case Operation.Subtract://условный оператор, в случае ввода в функцию Operation.Subtract
                    result = x - y;//присвоение результата вычитания двух чисел
                    break;//завершение выполнение блока команд
                case Operation.Multiply://условный оператор, в случае ввода в функцию Operation.Multiply
                    result = x * y;//присвоение результата умножения двух чисел
                    break;//завершение выполнение блока команд
                case Operation.Divide://условный оператор, в случае ввода в функцию Operation.Divide
                    result = x / y;//присвоение результата деления двух чисел
                    break;//завершение выполнение блока команд
            }

            Console.WriteLine("Результат операции равен {0}", result);//вывод на экран сообщения пользователю
        }

        static void Main(string[] args)
        {
            // Тип операции задаем с помощью константы Operation.Add
            MathOp(10, 5, Operation.Add);
            // Тип операции задаем с помощью константы Operation.Multiply
            MathOp(11, 5, Operation.Multiply);

            Console.ReadLine();//ожьдание нажатия клавиши
        }
    }
}

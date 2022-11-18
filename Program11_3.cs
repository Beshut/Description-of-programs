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
            StringBuilder hello = new StringBuilder("Привет, меня зовут Александр Ерохин", 120);//обьявление переменной, предоставляет изменяемую строку символов
            hello.AppendFormat(" Я рад вас приветствовать на моем сайте professorweb.ru");//добавляет строку, сформированную в соответствии со спецификатором формата
            // Зашифруем строку, хранящуюся в переменной hello
            Console.WriteLine("Исходная строка: \n {0}\n", hello);//вывод на экран сообщения пользователю

            for (int i = 'я'; i >= 'a'; i--)//условный оператор, выполняется пока i >= 'a'
                hello = hello.Replace((char)i, (char)(i + 3));//заменяет все вхождения симола другим символом


            Console.WriteLine("Зашифрованная строка:\n {0}", hello);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}

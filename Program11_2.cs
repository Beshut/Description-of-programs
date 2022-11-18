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
            hello.AppendFormat("Я рад вас приветствовать на моем сайте professorweb.ru");//вывод на экран сообщения пользователю
        }
    }
}

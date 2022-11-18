using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 45 };//обьявление списка обьектов
            numbers.Add(6);//добавление элемента

            numbers.AddRange(new int[] { 7, 8, 9 });//добавляет элементы интерфейса в конец списка

            numbers.Insert(0, 666);//вставляем на первое место в списке число 666

            numbers.RemoveAt(1);//удаляем второй элемент

            foreach (int i in numbers)//оператор перебора элементов массива
            {
                Console.WriteLine(i);//вывод на экран сообщения пользователю
            }

            List<Person> people = new List<Person>(3);//обьявление списка обьектов
            people.Add(new Person() { Name = "Том" });//добавление элемента
            people.Add(new Person() { Name = "Билл" });//добавление элемента

            foreach (Person p in people)//оператор перебора элементов массива
            {
                Console.WriteLine(p.Name);//вывод на экран сообщения пользователю
            }

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }

    class Person//новый тип, который определяется пользователем
    {
        public string Name { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

            var selectedTeams = from t in teams // определяем каждый объект из teams как t
                                where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                                orderby t  // упорядочиваем по возрастанию
                                select t; // выбираем объект

            foreach (string s in selectedTeams)
                Console.WriteLine(s);
            Console.WriteLine("");
            ///ФИЛЬТРАЦИЯ
            int[] numbers = { 1, 2, 3, 4, 10, 34, 55, 66, 77, 88 }; // массив
            IEnumerable<int> evens = numbers.Where(i => i % 2 == 0 && i > 10); // используем интрефейс Ienmerble  выражение в методе Where для определенного элемента будет равно true то данный элемент попадает в результирующую выборку.
            Console.WriteLine("");
            //Конец фильтрации

            ///Выборка сложных объектов
            List<User> users = new List<User> // список класса User
             {
                 new User {Name="Том", Age=24, Languages = new List<string> {"английский", "немецкий" }}, // создаём обьект класса user
                 new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                 new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                 new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var selectedUsers = from user in users
                                where user.Age > 25
                                select user;
            foreach (User user in selectedUsers)
                Console.WriteLine($"{user.Name} - {user.Age}");
            Console.WriteLine("");


            //Конец Выборки обьектов

            ///Выборка из нескольких источников
  
                List<User> usersi = new List<User>()
                {
                    new User { Name = "Sam", Age = 43 },
                    new User { Name = "Tom", Age = 33 }
                };

                List<Phone> phones = new List<Phone>()
                {
                        new Phone {Name="Lumia 630", Company="Microsoft" },
                        new Phone {Name="iPhone 6", Company="Apple"},
                };

                var people = from user in users
                             from phone in phones
                             select new { Name = user.Name, Phone = phone.Name };

                foreach (var p in people)
                    Console.WriteLine($"{p.Name} - {p.Phone}");

        }
    }
}

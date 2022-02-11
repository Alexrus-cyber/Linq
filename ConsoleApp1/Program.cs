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
            List<User> users = new List<User>
             {
                 new User {Name="Том", Age=24, Languages = new List<string> {"английский", "немецкий" }},
                 new User {Name="Боб", Age=27, Languages = new List<string> {"английский", "французский" }},
                 new User {Name="Джон", Age=29, Languages = new List<string> {"английский", "испанский" }},
                 new User {Name="Элис", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };

            var selectedUsers = from user in users
                                where user.Age > 25
                                select user;
            foreach (User user in selectedUsers)
                Console.WriteLine($"{user.Name} - {user.Age}");
        }
    }
}

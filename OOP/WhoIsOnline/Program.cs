using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace OOP.WhoIsOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>
            {
                new User("David", true, 9),
                new User("Lucy", false, 2),
                new User("Bob", true, 14),
                new User("Mark", true, 2)
            }.GroupBy(u => u.Status)
            .ToDictionary(k => k.Key, v => v.ToList());

            Console.WriteLine(JsonConvert.SerializeObject(users));
        }
    }
}
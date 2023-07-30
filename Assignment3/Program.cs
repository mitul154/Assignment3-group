﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            SLL users = new SLL();
            users.AddLast(new User(1, "Joe Blow", "jblow@gmail.com", "password"));
            users.AddLast(new User(2, "Joe Schmoe", "joe.schmoe@outlook.com", "abcdef"));
            users.AddLast(new User(3, "Colonel Sanders", "chickenlover1890@gmail.com", "kfc5555"));
            users.AddLast(new User(4, "Ronald McDonald", "burgers4life63@outlook.com", "mcdonalds999"));
            // Console.WriteLine(users.Count());
            // users.Add(new User(1200, "djiwaj", "jblow@gmail.com", "password"), 2);
            users.RemoveLast();

            Console.WriteLine(users);

            Console.WriteLine(users.GetValue(2).Name);
            Console.ReadLine();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            List<string> newWords = LinqProblems.RunProblem1(words);
            foreach(string word in newWords)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //Problem 2
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            List<string> newNames = LinqProblems.RunProblem2(names);
            foreach (string name in newNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            //Problem 3 & Problem 4
            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, "Mike", "Rodgers"),
                new Customer(2, "Nick", "Allen"),
                new Customer(3, "Jason", "Ryan"),
                new Customer(4, "Dan", "Laffey")
            };
            Customer customer1 = LinqProblems.RunProblem3(customers);
            Console.WriteLine(customer1.FirstName);
            Console.ReadLine();
            
            Customer customer2 = LinqProblems.RunProblem4(customers);
            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();

            //Problem 5
            List<string> classGrades = new List<string>()
            {
                "80,100,92,89,65", 
                "93,81,78,84,69",
                "73,88,83,99,64",
                "98,100,66,74,55"
            };

            double avg = LinqProblems.RunProblem5(classGrades);
            Console.WriteLine(avg);
            Console.ReadLine();
            //--------------------
            //Bonus Problem 1
            string letters = "terrill";

        }
    }
}

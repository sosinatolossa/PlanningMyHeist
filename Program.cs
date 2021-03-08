using System;
using System.Collections.Generic;

namespace PlanningMyHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            string question1 = "What is one of your team member's name?";
            Console.Write($"{question1} ");
            string Name = Console.ReadLine();

            string question2 = "Enter their skill level:";
            Console.Write($"{question2} ");
            string SkillLevel = Console.ReadLine();

            string question3 = "Enter their courage factor:";
            Console.Write($"{question3} ");
            string CourageFactor = Console.ReadLine();
        }
    }
}

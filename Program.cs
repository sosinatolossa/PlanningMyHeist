using System;
using System.Collections.Generic;

namespace PlanningMyHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");

            string qtnForName = "What is one of your team member's name?";
            Console.Write($"{qtnForName} ");
            string Name = Console.ReadLine();

            string qtnForSkillLevel = "Enter their skill level:";
            Console.Write($"{qtnForSkillLevel} ");
            string SkillLevel = Console.ReadLine();

            string qtnForCourageFactor = "Enter their courage factor. Their courage factor must be a decimal between 0.0 and 2.0.:";
            Console.Write($"{qtnForCourageFactor} ");
            string CourageFactor = Console.ReadLine();

            TeamMember teamMember1 = new TeamMember(Name, SkillLevel, CourageFactor);

            Console.WriteLine($"Team member's name: {teamMember1.Name}");
            Console.WriteLine($"Skill level: {teamMember1.SkillLevel}");
            Console.WriteLine($"Courage level: {teamMember1.CourageFactor}");

        }
    }
}

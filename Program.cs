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
            string name = Console.ReadLine();

            string qtnForSkillLevel = "Enter their skill level:";
            Console.Write($"{qtnForSkillLevel} ");
            int skillLevel = int.Parse(Console.ReadLine());

            string qtnForCourageFactor = "Enter their courage factor. What is the PercentageCut?";
            Console.Write($"{qtnForCourageFactor} ");
            int percentageCut = int.Parse(Console.ReadLine());

            //TeamMember teamMember1 = new TeamMember(Name, SkillLevel, CourageFactor);


            Bank usBank = new Bank()
            {
                AlarmScore = 98,
                VaultScore = 55,
            };

            Hacker hacker = new Hacker()
            {
                Name = name,
                SkillLevel = skillLevel,
                PercentageCut = percentageCut

            };
            Console.WriteLine($"Team member's name: {hacker.Name}");
            Console.WriteLine($"Skill level: {hacker.SkillLevel}");
            //Console.WriteLine($"Courage level: {hacker.CourageFactor}");

            hacker.PerformSkill(usBank);



        }
    }
}

using System;
using System.Collections.Generic;

namespace PlanningMyHeist
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        //string Name = "Ayelech";


        public void PerformSkill(Bank aBank)
        {
            // aBank is a single object that we passed in as an argument from Bank from Bank.cs
            aBank.AlarmScore = aBank.AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is performing robbery. Decreased security by {SkillLevel} points. The final percentage {aBank.AlarmScore}");
            if (aBank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}
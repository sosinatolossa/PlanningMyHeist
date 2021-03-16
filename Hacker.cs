using System;
using System.Collections.Generic;

namespace PlanningMyHeist
{
    public class Hacker : Bank, IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }


        public void PerformSkill()
        {
            int aBank = AlarmScore - SkillLevel;
            Console.WriteLine($"{Name} is performing {SkillLevel}. Decreased security by {aBank} points.");
            if (aBank <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}
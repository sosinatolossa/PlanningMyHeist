using System;
using System.Collections.Generic;

namespace PlanningMyHeist
{
    public interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }
        void PerformSkill(Bank aBank);
    }
}
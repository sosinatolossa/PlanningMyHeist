using System.Collections.Generic;

namespace PlanningMyHeist
{
    public class TeamMember
    {
        //public List<string> teamMembers { get; set; }
        public string Name { get; set; }
        public string SkillLevel { get; set; }
        public string CourageFactor { get; set; }

        public TeamMember(string name, string skillLevel, string courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
    }
}

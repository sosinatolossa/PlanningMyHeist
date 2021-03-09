using System.Collections.Generic;

namespace PlanningMyHeist
{
    public class TeamMember
    {
        //public List<string> teamMembers { get; set; }
        public string Name { get; }
        public string SkillLevel { get; }
        public string CourageFactor { get; }

        public TeamMember(string name, string skillLevel, string courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
    }
}

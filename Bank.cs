using System;
using System.Collections.Generic;

namespace PlanningMyHeist
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure(int score)
        {
            if (score <= 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
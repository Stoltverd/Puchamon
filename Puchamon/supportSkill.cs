using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    class supportSkill : Skill
    {
        public supportSkill(string name, byte power) : base(name, power)
        {
            if (power < 0 || power > 0 || power == 0)
                this.Power = 0;        
           

        }
        public void UseSkill(Critter objectiveName)
        {
            if (this.Name == "AtkUp" && objectiveName.NumAtkUp < 4)
            {
                objectiveName.SkillPower = 1.2f;
            }
            else
            {
                objectiveName.SkillPower = 1;
            }
        }
    }
}

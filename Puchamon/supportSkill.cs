using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    class supportSkill : Skill
    {
        public supportSkill(Affinity affinity,string name, byte power) : base(affinity, name, power)
        {
            if (power < 0 || power > 0 || power == 0)
                this.power = 0;        
           

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

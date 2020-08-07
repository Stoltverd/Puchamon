using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Puchamon
{
    class SupportSkill : Skill
    {
        public SupportSkill(string name, float power) : base(name, power)
        {
            if (power > 0 && power < 11)
            {
                this.Power = power;
            }
            else
            {
                
            }
            
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

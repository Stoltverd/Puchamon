using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Puchamon
{
    public class SupportSkill : Skill
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
    }
}

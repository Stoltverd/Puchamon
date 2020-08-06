using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    class attackSkill : Skill
    {

        public attackSkill(Affinity affinity, string name, byte power) : base(affinity, name, power)
        {
            if(power > 0 && power < 11)
            {
                this.power = power;
            }
        }

    }
}

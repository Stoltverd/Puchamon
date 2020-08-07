using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    class supportSkill : Skill
    {
        public supportSkill(Affinity affinity,string name, byte power) : base(affinity, name, power)
        {
            if (power <= 0)
                Power = 1;
            else if (power> 10)
                Power = 10;
            else
                Power = power;

        }
    }
}

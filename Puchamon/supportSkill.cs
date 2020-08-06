using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    class SupportSkill : Skill
    {
        public SupportSkill(Affinity affinity,string name, byte cost) : base(affinity, name, cost)
        {
            if (cost > 0 && cost < 11)
            {
                this.Cost = cost;
            }
            else
            {
                
            }
        }
    }
}

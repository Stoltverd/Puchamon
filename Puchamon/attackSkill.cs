using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{

    public enum Affinity
    {
        fire, earth, wind, dark, water, light
    }
    public class AttackSkill : Skill
    {
        private Affinity _affinity;
        private float damageValue;
        public Affinity Affinity { get => _affinity; set => _affinity = value; }
        public float DamageValue { get => damageValue; set => damageValue = value; }

        public AttackSkill(Affinity affinity, string name, byte power) : base(name, power)
        {
            
            
            if(power > 0 && power < 11)
            {
                this.Power = power;
                this.DamageValue = Power;
                this._affinity = affinity;
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    public class Critter
    {
        //Atributos
        private string name;
        private byte baseAtk, baseDef, baseSpeed, numAtkUp, numDefUp;
        private float skillPower, hp;
        Affinity _affinity;
        private List<Skill> moveSet = new List<Skill>();
        //Accesores
        public byte NumAtkUp { get => numAtkUp; set => numAtkUp = value; }
        public byte NumDefUp { get => numDefUp; set => numDefUp = value; }
        public float SkillPower { get => skillPower; set => skillPower = value; }
        public String Name { get => name; set => name = value; }
        public byte BaseAtk { get => baseAtk; set => baseAtk = value; }
        public byte BaseDef { get => baseDef; set => baseDef = value; }
        public byte BaseSpeed { get => baseSpeed; set => baseSpeed = value; }
        public float Hp { get => hp; set => hp = value; }
        public List<Skill> MoveSet { get => moveSet; set => moveSet = value; }
        public Affinity Affinity { get => _affinity; set => _affinity = value; }

        public Critter(string name, byte baseAtk, byte baseDef, byte baseSpeed, byte hp, List<Skill> moveSet, Affinity affinity)
        {
            this.Name = name;
            this.BaseAtk = baseAtk;
            this.BaseDef = baseDef;
            this.BaseSpeed = baseSpeed;
            this.Hp = hp;
            this.MoveSet = moveSet;
            this._affinity = affinity;
        }

        public void recieveDamage(Critter victim, AttackSkill source, float skillPower)
        {
            if (victim.Affinity == Affinity.dark && source.Affinity == Affinity.dark || 
                victim.Affinity == Affinity.light && source.Affinity == Affinity.light ||
                victim.Affinity == Affinity.fire && source.Affinity == Affinity.fire ||
                victim.Affinity == Affinity.fire && source.Affinity == Affinity.water ||
                victim.Affinity == Affinity.water && source.Affinity == Affinity.water ||
                victim.Affinity == Affinity.water && source.Affinity == Affinity.wind ||
                victim.Affinity == Affinity.wind && source.Affinity == Affinity.wind ||
                victim.Affinity == Affinity.earth && source.Affinity == Affinity.wind ||
                victim.Affinity == Affinity.earth && source.Affinity == Affinity.earth)
            {
                float AffinityMultiplier = 0.5f;
                Hp =- (source.DamageValue *= skillPower) * AffinityMultiplier;
            }
            else if (victim.Affinity == Affinity.light && source.Affinity == Affinity.light ||
                victim.Affinity == Affinity.earth && source.Affinity == Affinity.wind ||
                victim.Affinity == Affinity.water && source.Affinity == Affinity.fire ||
                victim.Affinity == Affinity.wind && source.Affinity == Affinity.water ||
                victim.Affinity == Affinity.wind && source.Affinity == Affinity.earth )
            {
                float AffinityMultiplier = 2f;
                Hp = -(source.DamageValue *= skillPower) * AffinityMultiplier;
            }
            else if (victim.Affinity == Affinity.fire && source.Affinity == Affinity.dark ||
                victim.Affinity == Affinity.fire && source.Affinity == Affinity.dark ||
                victim.Affinity == Affinity.fire && source.Affinity == Affinity.light ||
                victim.Affinity == Affinity.fire && source.Affinity == Affinity.wind ||
                victim.Affinity == Affinity.fire && source.Affinity == Affinity.earth ||
                victim.Affinity == Affinity.light && source.Affinity == Affinity.fire ||
                victim.Affinity == Affinity.light && source.Affinity == Affinity.water ||
                victim.Affinity == Affinity.light && source.Affinity == Affinity.wind ||
                victim.Affinity == Affinity.light && source.Affinity == Affinity.earth ||
                victim.Affinity == Affinity.dark && source.Affinity == Affinity.fire ||
                victim.Affinity == Affinity.dark && source.Affinity == Affinity.water ||
                victim.Affinity == Affinity.dark && source.Affinity == Affinity.wind ||
                victim.Affinity == Affinity.dark && source.Affinity == Affinity.earth ||
                victim.Affinity == Affinity.water && source.Affinity == Affinity.dark ||
                victim.Affinity == Affinity.water && source.Affinity == Affinity.light ||
                victim.Affinity == Affinity.water && source.Affinity == Affinity.earth ||
                victim.Affinity == Affinity.wind && source.Affinity == Affinity.dark ||
                victim.Affinity == Affinity.wind && source.Affinity == Affinity.light ||
                victim.Affinity == Affinity.wind && source.Affinity == Affinity.fire ||
                victim.Affinity == Affinity.earth && source.Affinity == Affinity.dark ||
                victim.Affinity == Affinity.earth && source.Affinity == Affinity.light ||
                victim.Affinity == Affinity.earth && source.Affinity == Affinity.water)
            {
                float AffinityMultiplier = 1f;
                Hp = -(source.DamageValue *= skillPower) * AffinityMultiplier;
            }
            else if (victim.Affinity == Affinity.earth && source.Affinity == Affinity.fire)
            {
                float AffinityMultiplier = 0f;
                Hp = -(source.DamageValue *= skillPower) * AffinityMultiplier;
            }
            else
            {
                throw new System.ArgumentException("Are you sure those affinities exist? Because I DON'T THINK SO YOU STUPID IDIOT :) ", "Affinity");
            }

        }
    }
}

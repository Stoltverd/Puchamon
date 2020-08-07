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
            this.SkillPower = 1;
            this.Name = name;
            if (baseAtk <= 0)
                this.BaseAtk = 1;
            else if (baseAtk > 100)
                this.BaseAtk = 100;
            else
                this.BaseAtk = baseAtk;

            if (baseDef <= 0)
                this.BaseDef = 1;
            else if (baseDef > 100)
                this.BaseDef = 100;
            else
                this.BaseDef = baseDef;

            if (baseSpeed <= 0)
                this.BaseSpeed = 1;
            else if (baseSpeed > 50)
                this.BaseSpeed = 50;
            else
                this.BaseSpeed = baseSpeed;
            if (hp <= 0)
                this.BaseSpeed = 1;
            else if (hp > 250)
                this.BaseSpeed = 250;
            else
                this.Hp = hp;
            this.Affinity = affinity;
            this.MoveSet = moveSet;
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
        public void recieveDamage(Critter victim, AttackSkill source)
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
                Hp = -(source.DamageValue *= skillPower) * AffinityMultiplier;
            }
            else if (victim.Affinity == Affinity.light && source.Affinity == Affinity.light ||
                victim.Affinity == Affinity.earth && source.Affinity == Affinity.wind ||
                victim.Affinity == Affinity.water && source.Affinity == Affinity.fire ||
                victim.Affinity == Affinity.wind && source.Affinity == Affinity.water ||
                victim.Affinity == Affinity.wind && source.Affinity == Affinity.earth)
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
        public void UseAtkSkill(Critter victim, AttackSkill name)
        {
            victim.recieveDamage(victim, name);
        }
        public void UseSupSkill(Critter objectiveName, SupportSkill name)
        {
            if (name.Name == "AtkUp" && objectiveName.NumAtkUp < 4)
            {
                objectiveName.SkillPower = 1.2f;
            }
            else
            {
                objectiveName.SkillPower = 1;
            }
            if (name.Name == "DefUp" && objectiveName.NumDefUp < 4)
            {
                objectiveName.SkillPower = -1.2f;
            }
            else
            {
                objectiveName.SkillPower = 1;
            }
        }


    }
}

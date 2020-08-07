using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    class Critter
    {
        //Atributos
        private string name;
        private byte baseAtk, baseDef, hp, baseSpeed;

        public enum Affinity
        {
            fire, earth, wind, dark, water, light
        }
        Affinity affinity;
        private List<Skill> moveSet = new List<Skill>();
        //Accesores
        public String Name { get => name; set => name = value; }
        public byte BaseAtk { get => baseAtk; set => baseAtk = value; }
        public byte BaseDef { get => baseDef; set => baseDef = value; }
        public byte Hp { get => hp; set => hp = value; }
        public List<Skill> MoveSet { get => moveSet; set => moveSet = value; }
        public byte BaseSpeed { get => baseSpeed; set => baseSpeed = value; }
        internal Affinity Affinity { get => affinity; set => affinity = value; }

        public Critter(string name, byte baseAtk, byte baseDef, byte hp, List<Skill> moveSet,
            Affinity affinity, byte baseSpeed)
        {
            /*-BaseAttack: El puntaje de ataque básico de la criatura, en un rango de 10 a 100.
            -BaseDefense: El puntaje de defensa básico de la criatura, en un rango de 10 a 100.
            -BaseSpeed: El puntaje de velocidad de la criatura, en un rango de 1 a 50. La criatura que
            -tenga mayor velocidad será la que ataque primero.
            */
            this.name = name;
            if (baseAtk <= 0)
                this.baseAtk = 1;
            else if (baseAtk > 100)
                this.baseAtk = 100;
            else
                this.baseAtk = baseAtk;

            if (baseDef <= 0)
                this.baseDef = 1;
            else if (baseDef > 100)
                this.baseDef = 100;
            else
                this.baseDef = baseDef;

            if (baseSpeed <= 0)
                this.baseSpeed = 1;
            else if (baseSpeed > 50)
                this.baseSpeed = 50;
            else
                this.baseSpeed = baseSpeed;

            this.hp = hp;
            this.affinity = affinity;



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

 }

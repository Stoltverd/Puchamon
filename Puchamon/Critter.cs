using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    class Critter
    {
        private string name;
        private byte baseAtk, baseDef, baseSpeed, numAtkUp; 
        private float skillPower, hp; 
        Affinity _affinity;
        private List<Skill> moveSet = new List<Skill>();
        //Accesores
        public byte NumAtkUp { get => numAtkUp; set => numAtkUp = value; } 
        public float SkillPower { get => skillPower; set => skillPower = value; } 
        public string Name { get => name; set => name = value; }
        public byte BaseAtk { get => baseAtk; set => baseAtk = value; }
        public byte BaseDef { get => baseDef; set => baseDef = value; }
        public byte BaseSpeed { get => baseSpeed; set => baseSpeed = value; }
        public float Hp { get => hp; set => hp = value; }
        public List<Skill> MoveSet { get => moveSet; set => moveSet = value; }
        public Affinity Affinity { get => _affinity; set => _affinity = value; }

        public Critter(string name, byte baseAtk, byte baseDef, float hp, List<Skill> moveSet,
            Affinity affinity, byte baseSpeed)
        {

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
                this.Hp = 1;
            else if (hp > 250)
                this.Hp = 250;
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

        void Setskills(Critter c, int i)
        {
            c.moveSet = new List<Skill>();
            if (i > 9 || i < 0)
                i = 1;

            //Fire options set
            attackSkill FireAtk = new attackSkill(Skill.Affinity.fire, "Fenix Punch", 5);
            attackSkill FireAtk1 = new attackSkill(Skill.Affinity.fire, "Fire Breath", 10);
            attackSkill FireAtk2 = new attackSkill(Skill.Affinity.fire, "Fire ball", 7);

            //Water Options Set
            attackSkill WaterAtk = new attackSkill(Skill.Affinity.water, "Squirt 7u7", 5);
            attackSkill WaterAtk1 = new attackSkill(Skill.Affinity.water, "Water whip", 6);
            attackSkill WaterAtk2 = new attackSkill(Skill.Affinity.water, "Super wave", 10);
            supportSkill Watersupport = new supportSkill(Skill.Affinity.water, "Miracle water", 0);
            //Dark Options Set
            attackSkill DarkAtk = new attackSkill(Skill.Affinity.dark, "Fear", 4);
            attackSkill DarkAtk1 = new attackSkill(Skill.Affinity.dark, "Toxic Shadow", 8);
            attackSkill DarkAtk2 = new attackSkill(Skill.Affinity.dark, "Embrace of darkness", 9);
            supportSkill Darksupport = new supportSkill(Skill.Affinity.dark, "Blue moon", 0);
            //Earth options set    
            attackSkill EarthAtk = new attackSkill(Skill.Affinity.earth, "Face rock punch", 4);
            attackSkill EarthAtk1 = new attackSkill(Skill.Affinity.earth, "Earthquake", 10);
            attackSkill EarthAtk2 = new attackSkill(Skill.Affinity.earth, "Face rock punch", 6);
            supportSkill Earthsupport = new supportSkill(Skill.Affinity.earth, "Ground Spikes", 0);
            //Wind options set 
            attackSkill WindAtk = new attackSkill(Skill.Affinity.wind, "Angry shout", 4);
            attackSkill WindAtk1 = new attackSkill(Skill.Affinity.wind, "Cyclon", 9);
            attackSkill WindAtk2 = new attackSkill(Skill.Affinity.wind, "Wind shear", 8);
            supportSkill Windsupport = new supportSkill(Skill.Affinity.wind, "Divine wind", 0);
            //Light options set    
            attackSkill LightAtk = new attackSkill(Skill.Affinity.wind, "Horus Eye", 4);
            attackSkill LightAtk1 = new attackSkill(Skill.Affinity.wind, "Redemption", 10);
            attackSkill LightAtk2 = new attackSkill(Skill.Affinity.wind, "Beacon", 6);
            supportSkill Lightsupport = new supportSkill(Skill.Affinity.light, "Lamp light", 0);


        }


    }
    
 }


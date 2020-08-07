using System;
using System.Collections.Generic;

namespace Puchamon
{
    class Program
    {
        static void Main(string[] args)
        {
            //abilities
            AttackSkill FireAtk = new AttackSkill(Affinity.fire, "Phoenix Punch", 5);
            AttackSkill FireAtk1 = new AttackSkill(Affinity.fire,"Fire Breath", 10);
            AttackSkill WaterAtk = new AttackSkill(Affinity.water, "Squirt 7u7", 5);
            SupportSkill Watersupport = new SupportSkill("Miracle water", 0);
            AttackSkill DarkAtk = new AttackSkill(Affinity.dark, "Fear", 4);
            SupportSkill Darksupport = new SupportSkill("Blue moon", 0);
            AttackSkill EarthAtk = new AttackSkill(Affinity.earth, "Face rock punch", 4);
            SupportSkill Earthsupport = new SupportSkill("Ground Spikes", 0);
            AttackSkill WindAtk = new AttackSkill(Affinity.wind, "Cyclon", 9);
            SupportSkill Windsupport = new SupportSkill( "Divine wind", 0);
            AttackSkill LightAtk = new AttackSkill(Affinity.wind, "Redemption", 10);
            SupportSkill Lightsupport = new SupportSkill("Lamp light", 0);

            //Move set 1 
            List<Skill> Set1 =  new List<Skill>();
            Set1.add(FireAtk, FireAtk1, Darksupport);
            //Move set 2
            List<Skill> Set2 = new List<Skill>();
            Set2.add(WaterAtk, WindAtk, LightAtk);
            //Move set 3
            List<Skill> Set3 = new List<Skill>();
            Set3.add(Watersupport, DarkAtk, EarthAtk);
            //Move set 4
            List<Skill> Set4 = new List<Skill>();
            Set4.add(Earthsupport, Windsupport, Lightsupport);


        }



    }
   
}

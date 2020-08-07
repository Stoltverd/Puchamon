using System;
using System.Collections.Generic;

namespace Puchamon
{
    class Program
    {
        static void Main(string[] args)
        {
            Critter critter = new Critter();
            
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
            supportSkill Watersupport= new supportSkill(Skill.Affinity.water, "Miracle water", 0);
            //Dark Options Set
            attackSkill DarkAtk = new attackSkill(Skill.Affinity.dark, "Fear", 4);
            attackSkill DarkAtk1 = new attackSkill(Skill.Affinity.dark, "Toxic Shadow", 8);
            attackSkill DarkAtk2 = new attackSkill(Skill.Affinity.dark, "Embrace of darkness", 9);
            supportSkill Darksupport= new supportSkill(Skill.Affinity.dark, "Blue moon", 0);
            //Earth options set    
            attackSkill EarthAtk = new attackSkill(Skill.Affinity.earth, "Face rock punch", 4);
            attackSkill EarthAtk1 = new attackSkill(Skill.Affinity.earth, "Earthquake", 10);
            attackSkill EarthAtk2 = new attackSkill(Skill.Affinity.earth, "Face rock punch", 6);
            supportSkill Earthsupport = new supportSkill(Skill.Affinity.earth, "Ground Spikes", 0);
            //Wind options set 
            attackSkill WindAtk = new attackSkill(Skill.Affinity.wind, "Angry shout", 4);
            attackSkill WindAtk1 = new attackSkill(Skill.Affinity.wind, "Cyclon", 9);
            attackSkill WindAtk2 = new attackSkill(Skill.Affinity.wind, "Wind shear", 8);
            supportSkill Windsupport= new supportSkill(Skill.Affinity.wind, "Divine wind", 0);
            //Light options set    
            attackSkill LightAtk = new attackSkill(Skill.Affinity.wind, "Horus Eye", 4);
            attackSkill LightAtk1 = new attackSkill(Skill.Affinity.wind, "Redemption", 10);
            attackSkill LightAtk2 = new attackSkill(Skill.Affinity.wind, "Beacon", 6);
            supportSkill Lightsupport = new supportSkill(Skill.Affinity.light, "Lamp light", 0);


            switch (a)
            {
                case Critter.Affinity.dark:
                    c.moveSet.add(DarkAtk);
                    break;
                case Critter.Affinity.earth:
                    c.moveSet.add(EarthAtk);
                    break;
                case Critter.Affinity.fire:
                    c.moveSet.add(FireAtk);
                    break;
                case Critter.Affinity.light:
                    c.moveSet.add(LightAtk);
                    break;
                case Critter.Affinity.water:
                    c.moveSet.add(WaterAtk);
                    break;
                case Critter.Affinity.wind:
                    c.moveSet.add(WindAtk);
                    break;
            }
            switch (i)
            {
                case i == 1:
                    c.MoveSet.add(FireAtk1);
                    c.MoveSet.add(WaterAtk1);
                    break;
                case i == 2:
                    c.MoveSet.add(FireAtk2);
                    c.MoveSet.add(Watersupport);
                    break;
                case i == 3:
                    c.MoveSet.add(DarkAtk1);
                    c.MoveSet.add(EarthAtk2);
                case i == 4:
                    c.MoveSet.add(LightAtk1);
                    c.MoveSet.add(Earthsupport);
                case i == 5:
                    c.MoveSet.add(WindAtk1);
                    c.MoveSet.add(Lightsupport);
                case i == 6:
                    c.MoveSet.add(DarkAtk2);
                    c.MoveSet.add(EarthAtk1);
                case i == 7:
                    c.MoveSet.add(WaterAtk2);
                    c.MoveSet.add(Windsupport);
                case i == 8:
                    c.MoveSet.add(Darksupport);
                    c.MoveSet.add(LightAtk2);


            }


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


        switch (a)
        {
            case Critter.Affinity.dark:
                c.moveSet.add(DarkAtk);
                break;
            case Critter.Affinity.earth:
                c.moveSet.add(EarthAtk);
                break;
            case Critter.Affinity.fire:
                c.moveSet.add(FireAtk);
                break;
            case Critter.Affinity.light:
                c.moveSet.add(LightAtk);
                break;
            case Critter.Affinity.water:
                c.moveSet.add(WaterAtk);
                break;
            case Critter.Affinity.wind:
                c.moveSet.add(WindAtk);
                break;
        }
        switch (i)
        {
            case i == 1:
                c.MoveSet.add(FireAtk1);
                c.MoveSet.add(WaterAtk1);
                break;
            case i == 2:
                c.MoveSet.add(FireAtk2);
                c.MoveSet.add(Watersupport);
                break;
            case i == 3:
                c.MoveSet.add(DarkAtk1);
                c.MoveSet.add(EarthAtk2);
            case i == 4:
                c.MoveSet.add(LightAtk1);
                c.MoveSet.add(Earthsupport);
            case i == 5:
                c.MoveSet.add(WindAtk1);
                c.MoveSet.add(Lightsupport);
            case i == 6:
                c.MoveSet.add(DarkAtk2);
                c.MoveSet.add(EarthAtk1);
            case i == 7:
                c.MoveSet.add(WaterAtk2);
                c.MoveSet.add(Windsupport);
            case i == 8:
                c.MoveSet.add(Darksupport);
                c.MoveSet.add(LightAtk2);


        }


    }
}

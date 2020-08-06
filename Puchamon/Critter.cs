using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    class Critter
    {
        //Atributos
        private string name;
        private byte baseAtk, baseDef, daseDef, hp;
        
       private enum Affinity
        {
            fire, earth, wind, dark, water, light
        }
        Affinity affinity;
        private List<Skill> moveSet = new List<Skill>();
        //Accesores
        public String Name { get => name; set => name = value; }
        public byte BaseAtk { get => baseAtk; set => baseAtk = value; }
        public byte BaseDef { get => baseDef; set => baseDef = value; }
        public byte DaseDef { get => daseDef; set => daseDef = value; }
        public byte Hp { get => hp; set => hp = value; }
        public List<Skill> MoveSet { get => moveSet; set => moveSet = value; }

        public Critter(string name, byte baseAtk, byte baseDef, byte daseDef, byte hp, List<Skill> moveSet, Affinity affinity)
        {
            this.Name = name;
            this.BaseAtk = baseAtk;
            this.BaseDef = baseDef;
            this.DaseDef = daseDef;
            this.Hp = hp;
            this.MoveSet = moveSet;
            this.affinity = affinity;
        }
    }
}

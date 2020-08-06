using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    public class Critter
    {
        //Atributos
        private string name;
        private byte baseAtk, baseDef, hp, baseSpeed;
        Affinity _affinity;
        private List<Skill> moveSet = new List<Skill>();
        //Accesores
        public String Name { get => name; set => name = value; }
        public byte BaseAtk { get => baseAtk; set => baseAtk = value; }
        public byte BaseDef { get => baseDef; set => baseDef = value; }
        public byte BaseSpeed { get => baseSpeed; set => baseSpeed = value; }
        public byte Hp { get => hp; set => hp = value; }
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
    }
}

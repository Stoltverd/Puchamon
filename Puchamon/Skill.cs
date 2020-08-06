using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    public enum Affinity
    {
        fire, earth, wind, dark, water, light
    }
    public abstract class Skill
    {
        
        private Affinity _affinity;
        private string name;
        private byte power;
        


        public Affinity Affinity { get => _affinity; set => _affinity = value; }
        public string Name { get => name; set => name = value; }
        public byte Power { get => power; set => power = value; }


        public Skill(Affinity affinity,string name, byte power)
        {
            this._affinity = affinity;
            this.name = name;
            this.power = power;
        }
        


    }
}

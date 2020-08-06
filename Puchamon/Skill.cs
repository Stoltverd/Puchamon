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
        private byte cost;
        // ojo. Los skills tienen costo, los puchamon poder 


        public Affinity Affinity { get => _affinity; set => _affinity = value; }
        public string Name { get => name; set => name = value; }
        public byte Cost { get => cost; set => cost = value; }


        public Skill(Affinity affinity,string name, byte cost)
        {
            this._affinity = affinity;
            this.name = name;
            this.cost = cost;
        }
    }
}

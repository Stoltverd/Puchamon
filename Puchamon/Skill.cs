using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
  public abstract class Skill
    {
       
        
        private string name;
        private byte power;

        public Affinity Affinity { get => affinity; set => affinity = value; }
        public string Name { get => name; set => name = value; }
        public byte Power { get => power; set => power = value; }

        public Skill(string name, byte power)
        {           
            this.name = name;
            this.power = power; 
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
  abstract class Skill
    {
        private enum Affinity
        {
            fire, earth, wind, dark, water, light
        }
        private Affinity affinity;
        private string name;
        private byte power;

        public Affinity Affinity { get => affinity; set => affinity = value; }
        public string Name { get => name; set => name = value; }
        public byte Power { get => power; set => power = value; }

        public Skill(Affinity affinity,string name, byte power)
        {
            this.Affinity = affinity;
            this.Name = name;
            this.Power = power;
        }
    }
}

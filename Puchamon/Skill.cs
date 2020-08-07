using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    
    public abstract class Skill
    {
        
        
        private string name;
        private float power;
        


        
        public string Name { get => name; set => name = value; }
        public float Power { get => power; set => power = value; }


        public Skill(string name, float power)
        {

            this.name = name;
            this.power = power;
        }
        


    }
}

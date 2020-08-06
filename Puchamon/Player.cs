using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    public enum Role
    {
        player,
        opponent
    }
    public class Player
    {
        //Atributes
        
        private Role _role;
        private List<Critter> critters = new List<Critter>();

        
        //properties
        public List<Critter> Critters { get => critters; set => critters = value; }
        public Role Role { get => _role; set => _role = value; }

        //Constructor
        public Player(List<Critter> Critters, Role role)
        {
            this._role = role;
            this.critters = Critters;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Puchamon
{
    class Player
    {
        //Atributes
        private enum Role
        {
            player,
            opponent
        }
        private Role role;
        private List<Critter> critters = new List<Critter>();

        
        //properties
        public List<Critter> Critters { get => critters; set => critters = value; }
        public Role Role1 { get => role; set => role = value; }

        //Constructor
        public Player(List<Critter> critters, Role role1)
        {
            this.Role1 = Role1;
            Critters = critters;
            Critters = critters;
            Role1 = role1;
        }


    }
}

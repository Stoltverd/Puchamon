using System;
using System.Collections.Generic;
using System.Linq;

namespace Puchamon
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean jugador y oponente
            Player player = new Player(Role.player);
            Player opponent = new Player(Role.opponent);

            //Se crean unos cuantos skills
            SupportSkill atkUp = new SupportSkill("AtkUp", 0);

            /*Se crean 2 puchamones para cada player
            Critter biggus = new Critter("Biggus Dickus", 80, 10, 2, 200,)*/

            //Chequea la hp del criter peleando y lo pasa de colección apenas se chorrea
            foreach (var critter in player.Critters)
            {
                if (critter.Hp <= 0)
                {
                    opponent.Critters.Add(critter);
                    player.Critters.Remove(critter);
                }
            }
            foreach (var critter in opponent.Critters)
            {
                if (critter.Hp <= 0)
                {
                    player.Critters.Add(critter);
                    opponent.Critters.Remove(critter);
                }
            }

        }



    }
}

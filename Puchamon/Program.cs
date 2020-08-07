using System;
using System.Collections.Generic;

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



        }



    }
}

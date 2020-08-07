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
            //Support
            SupportSkill atkUp = new SupportSkill("AtkUp", 0);
            SupportSkill defUp = new SupportSkill("DefUp", 0);
            SupportSkill spdUp = new SupportSkill("SpdUp", 0);
            //Ataque
            AttackSkill phoenixAtk = new AttackSkill(Affinity.fire, "Phoenix Punch", 5);
            AttackSkill fireBreath = new AttackSkill(Affinity.fire, "Fire Breath", 10);
            AttackSkill squirt = new AttackSkill(Affinity.water, "Squirt 7u7", 5);
            AttackSkill fear = new AttackSkill(Affinity.dark, "Fear", 4);
            AttackSkill rockPunch = new AttackSkill(Affinity.earth, "Face destroying rock-punch", 4);
            AttackSkill cyclon = new AttackSkill(Affinity.wind, "Cyclon", 9);


            //Se crean los movesets vacíos de los puchamón
            List<Skill> movesetBiggus = new List<Skill>();
            List<Skill> movesetFlacidus = new List<Skill>();

            List<Skill> movesetGonadude = new List<Skill>();
            List<Skill> movesetClitoron = new List<Skill>();

            //Agregamos skills a movesets. Profe, quiero que sepa que esta implementación fea y rara es culpa suya por poner cosas confusas e ilogicas de gusto para enseñarnos a 
            //trabajar. Solo digo... :D
            //Skills de BiggusDickus
            movesetBiggus.Add(defUp);
            movesetBiggus.Add(squirt);
            movesetBiggus.Add(fear);
            movesetBiggus.Add(rockPunch);

            //Skills de Flacidus
            movesetFlacidus.Add(atkUp);
            movesetFlacidus.Add(fireBreath);
            movesetFlacidus.Add(squirt);
            movesetFlacidus.Add(cyclon);

            //Skills de Gonadude
            movesetGonadude.Add(defUp);
            movesetGonadude.Add(fear);
            movesetGonadude.Add(fireBreath);
            movesetGonadude.Add(rockPunch);

            //Skills de Clitoron
            movesetClitoron.Add(spdUp);
            movesetClitoron.Add(squirt);
            movesetClitoron.Add(fear);
            movesetClitoron.Add(rockPunch);


            /*Se crean 2 puchamones para cada player*/
            Critter biggus = new Critter("Biggus Dickus", 80, 10, 2, 200, movesetBiggus, Affinity.fire);
            Critter flacidus = new Critter("Flacidus", 10, 80, 1, 100, movesetFlacidus, Affinity.earth);
            Critter gonaDude = new Critter("Gonadude", 50, 1, 20, 50, movesetGonadude, Affinity.dark);
            Critter clitoron = new Critter("Clitoron", 30, 60, 35, 60, movesetClitoron, Affinity.light);

            //Asignamos los puchamones a los jugadores
            player.Critters.Add(biggus);
            player.Critters.Add(gonaDude);

            opponent.Critters.Add(flacidus);
            opponent.Critters.Add(clitoron);

            //Que empiece el bonche hp. Los puchamones sacan los totes:
            //NOTA: Como el combate por turnos no se debía implementar y spdDown el diseñador no tiene idea de como debe funcionar (pues primero dice que baja la 
            //spd y luego que la aumenta... Ps inician en el orden que uno quiera
            Console.WriteLine("HP de Biggus Dickus: "+biggus.Hp);
            Console.WriteLine("¡Biggus Dickus usa Squirt contra Flacidus!");
            biggus.UseAtkSkill(flacidus, squirt);
            Console.WriteLine("HP de Flacidus: "+flacidus.Hp);
            Console.WriteLine("¡Flacidus usa AtkUp!");
            flacidus.UseSupSkill(flacidus, atkUp);
            Console.WriteLine("¡Biggus Dickus usa Face destroying rock-punch!");
            biggus.UseAtkSkill(flacidus, rockPunch);
            Console.WriteLine("HP de Flacidus: "+flacidus.Hp);

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

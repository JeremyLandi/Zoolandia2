using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Zoolandia.Animals;

namespace Zoolandia
{
    public class Program
    {
        public static int Main(string[] args)
        {

            HttpServer httpServer;
            if (args.GetLength(0) > 0)
            {
                httpServer = new MyHttpServer(Convert.ToInt16(args[0]));
            }
            else
            {
                httpServer = new MyHttpServer(8080);
            }
            Thread thread = new Thread(new ThreadStart(httpServer.listen));
            thread.Start();
            return 0;
        }
    }
}
            //Habitat savanna = new Habitat();
            //Habitat snakePit = new Habitat();
            //Habitat aviary = new Habitat();
            //Habitat aquarium = new Habitat();

            //Pool seaPool = new Pool();

            //savanna.inhabitants = new List<Animal>();

            //Bear yogi = new Bear();
            //yogi.name = "Yogi the Bear";
            //yogi.species = new PanPaniscus();

            //savanna.inhabitants.Add(yogi);

            //foreach (Animal a in savanna.inhabitants)
            //{
            //  Console.WriteLine();
            //}

            //BlackBear yogi = new BlackBear(240);
            //yogi.bearName = "Black Bear";
            //yogi.diet = "Honey, salmon, berries, small mammals";
            //yogi.habitat = "Forests";
            //yogi.endangered = false;

            //Bear Brown = new Bear(1400);
            //Brown.bearName = "Brown Bear";
            //Brown.diet = "Deer, nuts, elk, grass";
            //Brown.habitat = "Mountain Woodlands";
            //Brown.endangered = false;

            //Bear Polar = new Bear(990);
            //Polar.bearName = "Polar Bear";
            //Polar.diet = "Seals, walruses, bird eggs";
            //Polar.habitat = "Polar regions";
            //Polar.endangered = true;

            //Bear Panda = new Bear(280);
            //Panda.bearName = "Panda Bear";
            //Panda.diet = "Mostly bamboo and occasionally small rodents";
            //Panda.habitat = "Bamboo forests";
            //Panda.endangered = true;

            //Bear Sloth = new Bear(310);
            //Sloth.bearName = "Sloth Bear";
            //Sloth.diet = "insects(termites), fruit, and honeycombs";
            //Sloth.habitat = "Wet/dry forests and grasslands";
            //Sloth.endangered = true;

            //Whale Sperm = new Whale(32000);
            //Sperm.whaleName = "Sperm Whale";
            //Sperm.diet = "Squid, fish, eels, octopus";
            //Sperm.habitat = "Forests";
            //Sperm.endangered = false;

            //Whale Beluga = new Whale(3000);
            //Beluga.whaleName = "Beluga Whale";
            //Beluga.diet = "Salmon, crab, squid, and shrimp";
            //Beluga.habitat = "Artic and sub-artic waters";
            //Beluga.endangered = false;

            //Whale Blue = new Whale(420000);
            //Blue.whaleName = "Blue Whale";
            //Blue.diet = "Small krill and squid";
            //Blue.habitat = "Atlantic and Pacific Ocean";
            //Blue.endangered = true;

            //Whale Gray = new Whale(79000);
            //Gray.whaleName = "Gray Whale";
            //Gray.diet = "Crabs, lobsters, crayfish, shrimp";
            //Gray.habitat = "North Pacific";
            //Gray.endangered = false;

            //Whale Narwhal = new Whale(3500);
            //Narwhal.whaleName = "Narwhal Whale";
            //Narwhal.diet = "Cod, halibut, squid, and shrimp";
            //Narwhal.habitat = "Artic, Atlantic, and Pacific Oceans";
            //Narwhal.endangered = true;


            //Ape Gibbon = new Ape(20);
            //Gibbon.apeName = "Gibbon";
            //Gibbon.diet = "Fruit, leaves";
            //Gibbon.habitat = "Forests";
            //Gibbon.endangered = true;

            //Ape Orangutan = new Ape(200);
            //Orangutan.apeName = "Orangutan";
            //Orangutan.diet = "Fruit, leaves, flowers, insects";
            //Orangutan.habitat = "Lowland areas near river valleys";
            //Orangutan.endangered = true;

            //Ape Gorilla = new Ape(400);
            //Gorilla.apeName = "Gorilla";
            //Gorilla.diet = "Fruit, leaves, and insects";
            //Gorilla.habitat = "Mounains and forests";
            //Gorilla.endangered = true;

            //Ape Chimpanzee = new Ape(130);
            //Chimpanzee.apeName = "Chimpanzee";
            //Chimpanzee.diet = "Primarily herbivorous, it eats honey, insects, birds and their eggs";
            //Chimpanzee.habitat = "Woodlands and tropical rainforests";
            //Chimpanzee.endangered = true;

            //Ape Bonobo = new Ape(85);
            //Bonobo.apeName = "Bonobo";
            //Bonobo.diet = "Primarily fruit, but they also eat leaves, flowers, bark, stems, roots, insect";
            //Bonobo.habitat = "Tropical and subtropical forests";
            //Bonobo.endangered = true;
//        }
//    }
//}

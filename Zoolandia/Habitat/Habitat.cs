using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;

namespace Zoolandia
{
  class Habitat
  {
    public bool hasWalls;
    public bool outside;
    public string climateType;
    public bool isAquatic;
    public double ambientTemp;
    public double width;
    public double depth;
    public double height;
    public int windowCount;

    //aggrigate - hasA (strongly typed collection = can only contain what is in the list)
    public List<Animal> inhabitants;
    List<Decoration> decorations { get; set; }

  }
}

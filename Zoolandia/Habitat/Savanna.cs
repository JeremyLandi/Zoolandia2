using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{
  class Savanna : Habitat, IMoveable
  {
    string destination { get; set; }
    string currentLocation { get; set; }
  }
}

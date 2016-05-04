using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Bear : Animal
  {
    public string foodType = "Omnivore";
    public int legs = 4;
    public string bearyName { get; set; }
    public string diet { get; set; }
    public string habitat { get; set; }
    public bool endangered { get; set; }

  }
}

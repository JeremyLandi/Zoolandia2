using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Chimpanzee : Animal
  {
    public string foodType = "Omnivore";
    public int legs = 2;
    public string ChimpanzeeName { get; set; }
    public string diet { get; set; }
    public string habitat { get; set; }
    public bool endangered { get; set; }
  }
}

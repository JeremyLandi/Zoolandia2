using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Booby : Animal
  {
    public string foodType = "Carnivore";
    public int legs = 2;
    public string boobyName { get; set; }
    public string diet { get; set; }
    public string habitat { get; set; }
    public bool endangered { get; set; }
  }
 }

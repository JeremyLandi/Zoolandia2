using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Snake : Animal
  {
    public string foodType = "Carnivore";
    public int legs = 0;
    public string snakeName { get; set; }
    public string diet { get; set; }
    public string habitat { get; set; }
    public bool endangered { get; set; }
  }
 }


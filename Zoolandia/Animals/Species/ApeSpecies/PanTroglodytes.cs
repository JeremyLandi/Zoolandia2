using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class PanTroglodytes : Species
  {
        public string diet { get; set; }
        public bool endangered { get; set; }
        public string habitat { get; set; }

        public PanTroglodytes()
    {
      this.commonName = "Chimpanzee";
      this.scientificName = "Pan Troglodytes";
      this.genus = new Pan("Africa");
      this.url = "https://en.wikipedia.org/wiki/Common_chimpanzee";
      this.diet = "Fruit, leaves, bird eggs";
      this.habitat = "Woodlands and tropical rainforests";
      this.endangered = true;
    }
  }
}

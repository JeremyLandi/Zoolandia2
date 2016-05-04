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

    public string diet
    {
      get
      {
        throw new NotImplementedException();
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public bool endangered
    {
      get
      {
        throw new NotImplementedException();
      }

      set
      {
        throw new NotImplementedException();
      }
    }

    public string habitat
    {
      get
      {
        throw new NotImplementedException();
      }

      set
      {
        throw new NotImplementedException();
      }
    }
  }
}

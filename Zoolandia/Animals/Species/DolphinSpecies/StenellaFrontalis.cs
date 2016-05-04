using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class StenellaFrontalis : Species
  {
    public StenellaFrontalis()
    {
      this.commonName = "Atlantic Spotted Dolphin";
      this.scientificName = "Stenella Frontalisa";
      this.genus = new Stenella("Atlantic Ocean");
      this.url = "https://en.wikipedia.org/wiki/Atlantic_spotted_dolphin";
      this.diet = "Tuna and other fish";
      this.habitat = "Temperate and tropical";
      this.endangered = false;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class UrsusMaritimus : Species
  {
    public UrsusMaritimus()
    {
      this.commonName = "Polar Bear";
      this.scientificName = "Ursus Maritimus";
      this.genus = new Ursus("Antartica");
      this.url = "https://en.wikipedia.org/wiki/polar_bear";
      this.diet = "Seals, walruses, bird eggs";
      this.habitat = "Polar regions";
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
  }
}

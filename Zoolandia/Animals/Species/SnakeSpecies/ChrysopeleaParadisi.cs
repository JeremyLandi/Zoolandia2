using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class ChrysopeleaParadisi : Species
  {
    public ChrysopeleaParadisi()
    {
      this.commonName = " Paradise flying snake";
      this.scientificName = "Chrysopelea Paradisi";
      this.genus = new Chrysopelea("South East Asia");
      this.url = "https://en.wikipedia.org/wiki/Chrysopelea_paradisi";
      this.diet = "Lizards, frogs, bats, and birds";
      this.habitat = "Rain Forests";
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


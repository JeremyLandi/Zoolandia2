using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class ChrysopeleaOrnata : Species
  {
    public ChrysopeleaOrnata()
    {
      this.commonName = "Golden Tree Snake";
      this.scientificName = "Chrysopelea Ornata";
      this.genus = new Chrysopelea("South East Asia");
      this.url = "https://en.wikipedia.org/wiki/Chrysopelea_ornata";
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

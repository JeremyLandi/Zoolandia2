using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class UrsusUrsinus : Species

  {
    public UrsusUrsinus()
    {
      this.commonName = "Sloth Bear";
      this.scientificName = " Ursus Ursinus";
      this.genus = new Ursus("Asia");
      this.url = "https://en.wikipedia.org/wiki/Sloth_bear";
      this.diet = "Insects(termites), fruit, and honeycombs";
      this.habitat = "Wet/dry forests and grasslands";
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

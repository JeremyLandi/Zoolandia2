using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class StenellaCoeruleoalba : Species
  {
    public StenellaCoeruleoalba()
    {
      this.commonName = "Striped Dolphin";
      this.scientificName = "Stenella Coeruleoalba";
      this.genus = new Stenella("Pacific and Atlantic Ocean and Mediterranean Sea");
      this.url = "https://en.wikipedia.org/wiki/Striped_dolphin";
      this.diet = "Fish, squid, octopus, and krill";
      this.habitat = "Temperate and tropical waters";
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

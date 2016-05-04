using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
  { 
  class StenellaLongirostris : Species
  {
    public StenellaLongirostris()
    {
      this.commonName = "Spinner Dolphin";
      this.scientificName = "Stenella Longirostris";
      this.genus = new Stenella("Pacific, Atlantic, and Indian oceans");
      this.url = "https://en.wikipedia.org/wiki/Spinner_dolphin";
      this.diet = "Fish, squid, and shrimp";
      this.habitat = "Tropical and subtropical waters";
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

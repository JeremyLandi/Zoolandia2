using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class SulaDactylatra : Species
  {
    public SulaDactylatra()
    {
      this.commonName = "Austropacific Masked Booby";
      this.scientificName = "Sula Dactylatra";
      this.genus = new Sula("Austrailia and Pacific Islands");
      this.url = "https://en.wikipedia.org/wiki/Sula_Dactylatra";
      this.diet = "Fish and squid";
      this.habitat = "Islands on tropical islands";
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

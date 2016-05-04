using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class UrsusThibetanus : Species
  {
    public UrsusThibetanus()
    {
      this.commonName = "Moon Bear";
      this.scientificName = "Ursus thibetanus";
      this.genus = new Ursus("Asia");
      this.url = "https://en.wikipedia.org/wiki/Asian_black_bear";
      this.diet = "Insects, grass, fruit, and herbs";
      this.habitat = "Forests, deserts, and thornbrush forest";
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
  { 
  class BalaenopteraMusculus : Species
  {
    public BalaenopteraMusculus()
    {
      this.commonName = "Blue Whale";
      this.scientificName = "Balaenoptera Musculus";
      this.genus = new Balaenoptera("All Oceans");
      this.url = "https://en.wikipedia.org/wiki/Blue_Whale";
      this.diet = "Small krill and squid";
      this.habitat = "World ocean";
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

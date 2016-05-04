using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Chrysopelea : Genus
  {
    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Chrysopelea";
      this.commonName = "Flying Snake";
      this.scientificName = "Chrysopelea";
    }

    private string _continent;

    public string continent
    {
      get
      {
        return _continent;
      }
      set
      {
        if (value != "")
        {
          _continent = value;
        }
      }
    }

    public Chrysopelea()
    {
      this.init();
    }

    public Chrysopelea(string continent)
    {
      this.init();
      this.continent = continent;
    }
  }
}

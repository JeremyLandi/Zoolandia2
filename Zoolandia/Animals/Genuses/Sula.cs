using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Sula : Genus
  {
    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Booby";
      this.commonName = "Booby";
      this.scientificName = "Sula";
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

    public Sula()
    {
      this.init();
    }

    public Sula(string continent)
    {
      this.init();
      this.continent = continent;
    }
  }
}


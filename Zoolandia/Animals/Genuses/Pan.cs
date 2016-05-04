using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Pan : Genus
  {
    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Pan";
      this.commonName = "Chimpanzee";
      this.scientificName = "Pan";
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

    public Pan()
    {
      this.init();
    }

    public Pan(string continent)
    {
      this.init();
      this.continent = continent;
    }
  }
}

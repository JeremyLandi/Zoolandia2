using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Stenella : Genus
  {
    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Stenella";
      this.commonName = "Spotted Dolphin";
      this.scientificName = "Stenella";
    }

    private string _ocean;

    public string ocean
    {
      get
      {
        return _ocean;
      }
      set
      {
        if (value != "")
        {
          _ocean = value;
        }
      }
    }

    public Stenella()
    {
      this.init();
    }

    public Stenella(string ocean)
    {
      this.init();
      this.ocean = ocean;
    }
  }
}

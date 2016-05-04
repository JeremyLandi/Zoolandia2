using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
  class Balaenoptera : Genus
    {
      private void init()
      {
        this.url = "https://en.wikipedia.org/wiki/Balaenoptera";
        this.commonName = "Large Baleen Whale";
        this.scientificName = "Balaenoptera";
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

      public Balaenoptera()
      {
        this.init();
      }

      public Balaenoptera(string ocean)
      {
        this.init();
        this.ocean = ocean;
      }
    }
}

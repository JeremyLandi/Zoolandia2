using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class UrsusAmericanus : Species
  {
    public string diet { get; set; }
    public bool endangered { get; set; }
    public string habitat { get; set; }

    public UrsusAmericanus()
    {
      this.commonName = "North American Black Bear";
      this.scientificName = "Ursus Americanus";
      this.genus = new Ursus("North America");
      this.url = "https://en.wikipedia.org/wiki/American_black_bear";
      this.diet = "Honey, salmon, berries, small mammals";
      this.habitat = "Forests";
      this.endangered = false;
    }
  }
}


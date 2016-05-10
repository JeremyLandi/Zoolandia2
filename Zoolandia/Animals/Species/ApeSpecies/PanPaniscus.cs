using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class PanPaniscus : Species
  {
    public string diet { get; set; }
    public bool endangered { get; set; }
    public string habitat { get; set; }
    public PanPaniscus()
      {
        this.commonName = "Bonobo";
        this.scientificName = "Pan Troglodytes";
        this.genus = new Pan("Africa");
        this.url = "https://en.wikipedia.org/wiki/bonobo";
        this.diet = "Primarily fruit, but they also eat leaves, flowers, bark, stems, roots, insect";
        this.habitat = "Tropical and subtropical forests";
        this.endangered = true;
      }
    }
  }


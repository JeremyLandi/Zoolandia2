﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class UrsusArctos : Species
  {
    public UrsusArctos()
    {
      this.commonName = "Brown Bear";
      this.scientificName = "Ursus Arctos";
      this.genus = new Ursus("North America and Europe");
      this.url = "https://en.wikipedia.org/wiki/brown_bear";
      this.diet = "Deer, nuts, elk, grass";
      this.habitat = "Mountain Woodlands";
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
  }
}

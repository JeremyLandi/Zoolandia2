using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Models
{
    class Species
    {
        public int IdSpecies { get; set; }
        public int IdGenus { get; set; }
        public string scientificName { get; set; }
        public string commonName { get; set; }
        public string url { get; set; }
    }
}

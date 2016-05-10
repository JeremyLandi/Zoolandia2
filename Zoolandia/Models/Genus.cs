using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Models
{
    public class Genus
    {
        public int IdGenus { get; set; }
        public string scientificName { get; set; }
        public string commonName { get; set; }
        public string url { get; set; }
    }
}

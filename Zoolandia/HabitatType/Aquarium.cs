using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{
    class Aquarium : Habitat, IAquatic
    {

    public bool saltwater { get; set;}
    public double waterTemp { get; set; }
    public bool hasScubaCrew { get; set; }
    public List<Employees> scubaCrew { get; set; }
    
    
    public Aquarium(string name, bool isSaltwater)
        {
            saltwater = isSaltwater;
            this.public_name = name;
        }
    }
}

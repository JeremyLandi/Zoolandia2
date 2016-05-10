using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia
{
    interface IAquatic
    {
        double waterTemp { get; set; }
        bool saltwater { get; set; }
        bool hasScubaCrew { get; set; }
        List<Employees> scubaCrew { get; set; }

        //string Aquarium(string name, bool isSaltwater);

  }
}

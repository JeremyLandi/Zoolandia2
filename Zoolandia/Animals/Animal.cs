using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Interfaces;

namespace Zoolandia.Animals
{
  class Animal : IAnimal
  {
    private string _name = "";
    private string _food = null;
    private Species _species;

    public Species species
    {
      get
      {
        return _species;
      }
      set
      {
        _species = value;
      }
    }

    public string name
    {
      get
      {
        return _name;
      }
      set
      {
        if (value != "")
        {
          _name = value;
        }

      }
    }

    public string food
    {
      get
      {
        return _food;
      }
      set
      {
        if (value != "")
        {
          _food = value;
        }
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

    public void eat()
    {
      if (_food == null)
      {
        Console.WriteLine("No food provided yet");
      }
    }

    public virtual void eat(string food)
    {
      _food = food;
      Console.WriteLine("Currently eating {0}", food);
    }

    public void sleep()
    {
      throw new NotImplementedException();
    }

    public virtual void move()
    {
      throw new NotImplementedException();
    }

    public void reproduce()
    {
      throw new NotImplementedException();
    }
  }
}

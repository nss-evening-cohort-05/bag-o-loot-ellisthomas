using System;
using System.Collections.Generic;
using System.Linq;

namespace BagOLoot
{
  public class ToyRegister
  {
    private List<Toy> _toys = new List<Toy>();

    public Toy Add(string toy, Child child)
    {
      // Create new toy instance
      Toy newToy = new Toy(){
        name = toy,
        child = child
      };

      // Add to private collection
      _toys.Add(newToy);

      return newToy;
    }

    public Toy RevokeToy( Toy toy) 
    { 
      _toys.Remove(toy);
      return toy;
     
    }

    public List<Toy> GetToysForChild(Child kid)
    {
      var kidsToys = from toy in _toys
                        where toy.child == kid
                        select toy;

        return kidsToys.ToList();
    }
  }
}  

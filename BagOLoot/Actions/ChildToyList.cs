using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class ToyList
  {
    public static void Show(ToyRegister bag, ChildRegister book)
    {
      Console.Clear();
      Console.WriteLine ("Revoke toy");
        var kid = KidsMenu.Show(book);

        var toys = bag.GetToysForChild(kid).ToArray();
        foreach (var toy in toys)
        {
            Console.WriteLine($"{Array.IndexOf(toys, toy) + 1}. {toy.name}");
        }
        Console.Write("> ");
        var toyChoice = Console.ReadLine();
        var chosenToy = toys[int.Parse(toyChoice) - 1];

       
    
    }
  }
}

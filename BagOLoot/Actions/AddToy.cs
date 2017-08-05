using System;
using System.Collections.Generic;


namespace BagOLoot.Actions
{
  public class AddToy
  {
    public static void DoAction(ToyRegister bag, ChildRegister book)
    {
      var kid = KidsMenu.Show(book);
      
      Console.WriteLine ("Enter toy");
      Console.Write ("> ");
      string toyName = Console.ReadLine();
      bag.Add(toyName, kid);
    }
  }
}

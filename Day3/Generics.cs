using System.Collections.Generic;
 public class Test2
{
  public void greeting()
  {
      List<string> str=new List<string>();
      str.Add("Shiwansh");
      str.Add("Kanishk");

       foreach(string list in str)     // IEnumberable  (Here no unboxing is required)
        {
            Console.WriteLine(list);
        }

  }
  
}
using System.Collections;
 public class Test1
{
  public void greeting()
  {
     ArrayList arrayList=new ArrayList();
     arrayList.Add(10);             // Go inside heap through object datatype. 
     arrayList.Add("Shiwansh");     //Value type to reference type.

     foreach(object list in arrayList)     // IEnumberable  
        {
            Console.WriteLine(list);
        }

  }
  
}
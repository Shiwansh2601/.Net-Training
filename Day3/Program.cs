/*

class Employee
{
  public void greeting()
  {
    object age=21;  //Value type --->Reference ---->Boxing

    //Explicit conversion required here.


    int a=(int)age;   // Old ways
    int b=Convert.ToInt32(age);  // New ways with Convert class;
    

    Console.WriteLine(a + b);

  }
   public static void Main()
  {
     Employee employee=new Employee();
     employee.greeting();

  }
}

*/


public class Evaluation
{
    public static void Main()
    {
        

        Test1 t1=new Test1();    
        t1.greeting();
        

        Test2 t2=new Test2();
        t2.greeting();

    }
}





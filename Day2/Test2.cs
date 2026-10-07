

/*

class Team
{
    public virtual void DeadLine()
    {
        Console.WriteLine(" Achie......");
    }
}

class Employee:Team
{
    public  void DeadLine()
    {
        Console.WriteLine("Need ...........");
    }
}

public class Evaluation
{
    public static void Main()
    {
        

        Team t1=new Employee();     //Late binding
        t1.DeadLine();



        

    }
}


*/


using System;

abstract class Team
{
    public abstract  void DeadLine();
   
}

class Employee:Team
{
    public  override void DeadLine()
    {
        Console.WriteLine("Need ...........");
    }
}


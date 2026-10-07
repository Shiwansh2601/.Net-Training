delegate void mydelegate(); //can hold the reference of method for no type and no parameterm 
public class Delegate
{
    public void Task()
    {
        Console.WriteLine("Task start...");
    }

    public int Expense()
    {
        return 1000;
    }

     public void Report()
    {
        Console.WriteLine("reporting to manager......");
    }

}


/* public class Test
{
    public static void Main()
    {
        Delegate del=new Delegate();

        mydelegate my=new mydelegate(del.Task);//my act as function pointer & my* holds the ref of instance class method.

        my+=del.Report;   //Multicast delegate. += Multicast

       // my.Invoke();  //Invoke is function to excute a delegate and delegate execute task().

        my.Invoke();// it will call all all methods..

        
    }
} */

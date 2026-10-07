
// Generics Interface .........................................................
/* class Test
{
    public static void Main()
    {
        IWork<int> work = new Umar();
        work.Task(25);

        IWork<string> work1 = new Sandeep();
        work1.Task("2 days");


    }
} */



// Generics Constraints ...............................................................
/* class Test
{
    
    public static void Main()
    {
        Emp<string> emp=new Emp<string>(); // for reference type 
        emp.Task("Iist");

       // Emp<int> emp=new Emp<int>(); // for value type 
       // emp.Task("Iist");

    }
} */




//  Garbage Collection  main ...................................................................
/* public class Task
{
    public static void Main()
    {
       using( Garbage garbage=new Garbage())  // Garbage at this point GC will call automatically to call to dispose function to clean memory.
        {
            garbage.Assign(10); 
        }
        
    }
} */





//Delagate  Test code .....................................................................................

/* public class Test
{
    public static void Main()
    {
        Delegate del=new Delegate();

        mydelegate my=new mydelegate(del.Task);//my act as function pointer .

        my+=del.Report;   //Multicast delegate. += Multicast

       // my.Invoke();  //Invoke is function to excute a delegate and delegate execute task().

        my.Invoke();// it will call all all methods..

        
    }
} */
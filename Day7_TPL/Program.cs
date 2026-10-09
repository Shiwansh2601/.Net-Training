/* // Limitations of Synchronous Programming(10,13,15) run on single main thread . Sabse bada kutta 13 line no pe hai jo 10 second le rha hai.

using System.Threading;

class Product
{
    
    public static void Main()  // Synchronous programming ho rhi hai..
    {
        Console.WriteLine("I am doing some work..."); // father apna kaam kr liye...

        Product obj=new Product();
        obj.FetchData();  // whole process is delayed due to this Fetch data function.  it should be call over Separate Thread.

        Console.WriteLine("Doing some task in kitchen..");// Mom ka kaam 10 second me hoga..


    }

    public void FetchData()
    {
        Thread.Sleep(10000); // 10 second

        Console.WriteLine("Work is Over");
    }
}


// Agenda Day 8:
// Convert this to TPL then convert the EmployeeMGST system program to TPL +DTO

// Event Using Delegates.
// Access Modifiers. */
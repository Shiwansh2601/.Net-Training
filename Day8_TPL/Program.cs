using System;
using System.Threading.Tasks;

/* class EmployeeMGST
{
    public static async Task Main()
    {
       Task<int>res= Task.Run(LongRunningFunc);
       

      int temp= await res;
      Console.WriteLine(temp);






    }

    public static int LongRunningFunc()
    {
        Thread.Sleep(6000);

        return 123;
    }
} */



/* 
class EmployeeMGST
{
    public static async Task Main()
    {
       await Task.Run(DownloadSong);


       Console.WriteLine("Main fuctions.....");
    }

    public static void DownloadSong()
    {
        Thread.Sleep(6000);

        Console.WriteLine("Lata Didi");
    }
}
 */

using System;
using System.Threading;
using System.Threading.Tasks;

class Product
{
  public static async Task Main()
  {

    Product p = new Product();



    await Task.Run(p.GetDot);
    await Task.Run(p.GetBreakFast);
    await Task.Run(p.GetDot);

    



  }

  public void GetBreakFast()
  {
    Thread.Sleep(10000);

    Console.WriteLine("Food is preparing ....");
  }


  public void GetDot()
  {


    Console.WriteLine("................");
  }
}
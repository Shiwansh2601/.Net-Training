using System;

//Implementation of garbage collection
public class Garbage:IDisposable //if u need explicit deallocation of  the memmory then use this interface
{
    int id; //instance variable
  private bool disposedValue;

  public void Assign(int i)
    {
        id =i;

        Console.WriteLine(id);
    }

  protected virtual void Dispose(bool disposing)
  {
    if (!disposedValue)
    {
      if (disposing)
      {
        // TODO: dispose managed state (managed objects)
      }

      // TODO: free unmanaged resources (unmanaged objects) and override finalizer
      // TODO: set large fields to null
      disposedValue = true;

      Console.WriteLine("Dispose function will automatically call....");
    }
  }

  // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
  // ~Garbage()
  // {
  //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
  //     Dispose(disposing: false);
  // }

  public void Dispose()
  {
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
  }
}


//public class Emp<T> where T:struct // struct refer to value type 
public class Emp<T> where T:class  // class refer to reference type.
{
    public void Task(T data)
    {
        Console.WriteLine(data);
    }
}


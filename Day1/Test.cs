/*   

using System;
class Test
{    int marks;
    public void marksGrading(int marks)
    {
        if(marks>=90)
        {
            Console.WriteLine("Grade A");
        }
        else if(marks>=75)
        {
            Console.WriteLine("Grade B");
        }
        else if(marks>=35)
        {
            Console.WriteLine("Grade C");
        }
        else
        {
            Console.WriteLine("Fail");
        }
    }
    public static void Main()
    {
        Console.WriteLine("............Marks Grading System........");
        Console.Write("Enter Your Marks: ");
        Test t=new Test();
        t.marks=Convert.ToInt32(Console.ReadLine());
        t.marksGrading(t.marks);
    }
}

*/



class Test
{ 
    public static void Main()
    {
        String[] names={"Amit","Shiwansh","Kanishk","Shreya","Sakshi"};
        Console.WriteLine("While loop Implementations.....");
        int j=0;
        int n=names.Length;
        while(j<n)
        {
            Console.Write(names[j++]+" ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("for loop Implementations.....");
         for(int i=0;i<names.Length;i++)
        {
            Console.Write(names[i]+" ");
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("foreach loop Implementations.....");
        foreach(String name in names)
        {
            Console.Write(name+" ");
        }
    }
}


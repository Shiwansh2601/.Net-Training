using Day6.Models;
using Day6.Operations;
using Day6.Servic;
class Test
{
    public static void Main()
    {
        IEmployeeOperation employeeOperation = new EmployeeOperation();

        // ADD EMPLOYEE ---------------------------------



        Employee employee1 = new Employee
        {
            Id = 101,
            Name = "Shanu",
            Age = 16
        };

        Employee employee2 = new Employee
        {
            Id = 102,
            Name = "Shiw",
            Age = 33
        };
        Employee employee3 = new Employee
        {
            Id = 103,
            Name = "Shruti",
            Age = 14
        };

        Employee employee4 = new Employee
        {
            Id = 104,
            Name = "Shyam",
            Age = 19
        };

        Employee employee5 = new Employee
        {
            Id = 105,
            Name = "Shalone",
            Age = 14
        };
        Employee employee6 = new Employee
        {
            Id = 106,
            Name = "Shweta",
            Age = 19
        };

        Employee emp1 = employeeOperation.Add(employee1);

        Console.WriteLine($"Employee added successfully: {emp1.Name}");

        Employee emp2 = employeeOperation.Add(employee2);

        Console.WriteLine($"Employee added successfully: {emp2.Name}");

        Employee emp3 = employeeOperation.Add(employee3);

        Console.WriteLine($"Employee added successfully: {emp3.Name}");

        Employee emp4 = employeeOperation.Add(employee4);

        Console.WriteLine($"Employee added successfully: {emp4.Name}");

        Employee emp5 = employeeOperation.Add(employee5);

        Console.WriteLine($"Employee added successfully: {emp5.Name}");

        Employee emp6 = employeeOperation.Add(employee6);

        Console.WriteLine($"Employee added successfully: {emp6.Name}");







        Employee updatedEmployee = new Employee
        {
            Name = "Shiwansh",
            Age = 21
        };

        Employee result =
            employeeOperation.UpdateEmployee(updatedEmployee, 101);

        Console.Write("Employee updated successfully. Updated Record : ");

        Console.WriteLine(
            $"{result.Id} {result.Name} {result.Age}"
        );






        if (employeeOperation.GetEmployeeById(101, out Employee emp101))
        {
            Console.WriteLine(" Record fetched :" + emp101.Name);
        }
        else
        {
            Console.WriteLine("Record not found....");
        }





        // DELETE EMPLOYEE ---------------------------------------



        Employee emp = employeeOperation.DeleteEmployee(101);

        Console.WriteLine("Employee deleted successfully." + emp.Name);


        // GetEmployeesByAge  Employee.

        List<Employee> list = employeeOperation.GetEmployeesByAge(18);

        if (list.Count == 0)
        {
            Console.WriteLine("Record Not found..");
        }
        else
        {
            foreach (Employee e in list)
            {
                Console.WriteLine(e.Id + " " +e.Name+" "+e.Age);
            }
        }

        Console.WriteLine("Sorted List : ");
        List<Employee> sortedList=employeeOperation.GetEmployeesInSortedOrder();

        foreach(var el in sortedList)
        {
            Console.WriteLine(el.Id+" "+el.Name+" "+el.Age);
        }


    }

}
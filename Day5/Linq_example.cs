/* 
using System;
using System.Collections.Generic;
using System.Linq;

// Represents an employee in our application.
class Employee  //model 
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

// Defines the operations that can be performed on employees.
interface IEmployeeOperation
{
    int Add(Employee employee);
    List<Employee> GetEmployees();
    void GetEmployeeById(int id);
    Employee UpdateEmployee(Employee employee, int id);
    int DeleteEmployee(int id);
}

// Contains the actual employee operations.
class EmployeeOperation : IEmployeeOperation
{
    // List is used to store employee records in memory.
    private List<Employee> employees = new List<Employee>();

    // Adds a new employee to the list.
    public int Add(Employee employee)
    {
        // Throw an exception when invalid data is passed.
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee));
        }

        if (employee.Id <= 0)
        {
            throw new ArgumentException("Employee ID must be greater than 0.");
        }

        if (string.IsNullOrWhiteSpace(employee.Name))
        {
            throw new ArgumentException("Employee name cannot be empty.");
        }

        if (employee.Age <= 0)
        {
            throw new ArgumentException("Employee age must be greater than 0.");
        }

        employees.Add(employee);

        return 1;
    }

    // Returns all employees.
    public List<Employee> GetEmployees()
    {
        return employees;
    }

    // Finds and displays an employee using the employee ID.
    public void GetEmployeeById(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Employee ID must be greater than 0.");
        }

    
        // FirstOrDefault() returns the first matching employee
        // or null if no employee is found.
        Employee? employee = employees
            .FirstOrDefault(e => e.Id == id);

        if (employee == null)
        {
            throw new Exception("Employee not found.");
        }

        Console.WriteLine(
            $"Records : ID: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}"
        );
    }

    // Updates the name and age of an existing employee.
    public Employee UpdateEmployee(Employee employee, int id)
    {
        if (employee == null)
        {
            throw new ArgumentNullException(nameof(employee));
        }

        if (id <= 0)
        {
            throw new ArgumentException("Employee ID must be greater than 0.");
        }

        // Find() returns the first employee matching the condition.
        Employee? existingEmployee = employees.Find(e => e.Id == id);

        if (existingEmployee == null)
        {
            throw new Exception("Employee not found.");
        }

        existingEmployee.Name = employee.Name;
        existingEmployee.Age = employee.Age;

        return existingEmployee;
    }

    // Deletes an employee using the employee ID.
    public int DeleteEmployee(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("Employee ID must be greater than 0.");
        }

        Employee? employee = employees.Find(e => e.Id == id);

        if (employee == null)
        {
            throw new Exception("Employee not found.");
        }

        employees.Remove(employee);

        return 1;
    }
}

class Ui
{
    public static void Main()
    {
        IEmployeeOperation employeeOperation = new EmployeeOperation();

        // ADD EMPLOYEE ---------------------------------

        try
        {
            Employee employee = new Employee
            {
                Id = 101,
                Name = "Shanu",
                Age = 22
            };

            employeeOperation.Add(employee);
       
            Console.WriteLine("Employee added successfully.");
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }


        // UPDATE EMPLOYEE -------------------------------

        try
        {
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
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }


        // GET EMPLOYEE ----------------------------------

        try
        {
            employeeOperation.GetEmployeeById(101);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }


        // DELETE EMPLOYEE ---------------------------------------

        try
        {
            employeeOperation.DeleteEmployee(101);

            Console.WriteLine("Employee deleted successfully.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

  // this program is not appropriate for project level because there is no logical structure.


} */
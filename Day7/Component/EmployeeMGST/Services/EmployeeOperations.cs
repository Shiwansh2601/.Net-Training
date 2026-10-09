using System;
using EmployeeMGST.Models;
using EmployeeMGST.Operations;

namespace EmployeeMGST.Services
{
    public class EmployeeOperation : IEmployeeOperation
    {
        private List<Employee> employees = new List<Employee>();

    public List<Employee> GetEmployeesByAge(int age)
    {
       List<Employee> emplist=employees.Where(e => e.Age> age).ToList(); // Here query is not executed bcz it follows defered execution.

       // it will execute when we foreach.

       return emplist;
    }

    public List<Employee> GetEmployeesInSortedOrder()
    {
         List<Employee>emp=employees.OrderBy(e=>e.Age).ToList(); // OrderBy use.

         return emp;
    }

    Employee IEmployeeOperation.Add(Employee employee)
        {
            employees.Add(employee);
            return employee;
        }

         Employee IEmployeeOperation.DeleteEmployee(int id)
        {
             

            var emp = employees.Find(e => e.Id == id);
            if (emp != null)
            {
                employees.Remove(emp);
            }
            return emp;
        }

        bool IEmployeeOperation.GetEmployeeById(int id, out Employee emp)
        {
            var checkemp = employees.Find(e => e.Id == id);

            if(checkemp!=null)
            {
                emp=checkemp;
                return true;
            
            }
            

            emp=null;
            return false;
            
        }

       async Task< List<Employee>> IEmployeeOperation.GetEmployees()
        {

            await Task.Delay(2000);
            return employees;
        }

        async Task<Employee>IEmployeeOperation.UpdateEmployee(Employee employee, int id)
        {

           await Task.Delay(2000);
            var exist = employees.Find(e => e.Id == id);
            if (exist != null)
            {
                exist.Name=employee.Name;
                exist.Age=employee.Age;
                return exist;
            }
            return null;
        }
    }
}


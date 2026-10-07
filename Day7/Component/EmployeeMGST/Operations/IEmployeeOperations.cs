using EmployeeMGST.Models;

namespace EmployeeMGST.Operations
{
    // All function are blocking(apply task library)
    public interface IEmployeeOperation
    {
        Employee Add(Employee employee);
        List<Employee> GetEmployees();
        bool GetEmployeeById(int id,out Employee emp); //Apply DTO with projection query
        Employee UpdateEmployee(Employee employee,int id);
        Employee DeleteEmployee(int id);

        List<Employee> GetEmployeesByAge(int age);

        List<Employee> GetEmployeesInSortedOrder();
    }
}
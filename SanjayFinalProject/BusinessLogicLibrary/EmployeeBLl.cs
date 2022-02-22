using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary;


namespace BusinessLogicLibrary
{
    public class EmployeeBLl
    {
        public static bool AddEmployee(int empId, string empName, int empSalary, int empAge)
        {
            var result=EmployeeDAL.AddEmployee(empId, empName, empSalary, empAge);  
            return result;
        }
        public static List<string> GetEmployeeById(int id)
        {
            var result = EmployeeDAL.GetEmployeeById(id);
            return result;
        }
        public static List<string> GetEmployeeByName(string name)
        {
            var result = EmployeeDAL.GetEmployeeByName(name);
            return result;
        }
        public static string[] GetAllEmployees()
        {
            var result = EmployeeDAL.GetAllEmployees();
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesLibrary
{
    public delegate List<EmployeeOperations> DelegateForShowingList();
    public class EmployeeOperations
    {
        public int Empid { get; set; }
        public string EmpName { get; set; }

        public List<EmployeeOperations> ShowEmpList() 
        {

            EmployeeOperations emp1=new EmployeeOperations();
            emp1.Empid = 1;
            emp1.EmpName = "Suraj";

            EmployeeOperations emp2 = new EmployeeOperations();
            emp2.Empid = 2;
            emp2.EmpName = "Jack";

            EmployeeOperations emp3 = new EmployeeOperations();
            emp3.Empid = 3;
            emp3.EmpName = "Jill";

            List<EmployeeOperations> employees = new List<EmployeeOperations>();    
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            return employees;   


        }
    }
}

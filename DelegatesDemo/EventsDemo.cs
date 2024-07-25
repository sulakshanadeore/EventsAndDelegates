using DelegatesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo
{
    internal class EventsDemo
    {
      static   event DelegateForShowingList ev_ViewData;

        static void Main(string[] args)
        {
            
            EmployeeOperations operations = new EmployeeOperations();
            DelegateForShowingList del = new DelegateForShowingList(operations.ShowEmpList);//attached the method to delegate
            List<EmployeeOperations> elist = new List<EmployeeOperations>();
         
            ev_ViewData = del;
            
            elist= ev_ViewData();
            foreach (EmployeeOperations el in elist)
            {
                Console.WriteLine(el.Empid);
                Console.WriteLine(el.EmpName);
            }
            Console.ReadLine();
















        }
    }
}

using CSharpGoFSample.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoFSample.FactoryMethod
{
    internal class EmployeePool
    {
        private Dictionary<string, Employee> pool = new Dictionary<string, Employee>();
        public void PutEmployee(Employee employee)
        {
            pool[employee.Unit] = employee;
        }

        public Employee GetEmployee(string unit, string name) 
        {
            Employee result = pool[unit] ?? null; // これでいけるのか知らない
            if (result == null)
            {
                Employee employee = new Employee(unit);
                pool.Add(unit, employee);
            }
            result.Name = name;
            result.Unit = unit;
            return result;
        }
    }
}

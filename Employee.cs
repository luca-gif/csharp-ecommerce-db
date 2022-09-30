using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ecommerce_db
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Level { get; set; }
        public List<Employee> Employees { get; set; }

        public Employee(int id, string name, string surname, int level)
        {
            EmployeeId = id;
            Name = name;
            Surname = surname;
            Level = level;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototypeDLL.Metrics
{
    public class Employee : VMetric
    {
        public int Salary { get; set; }
        public int Bonus { get; set; }
        public int TotalCompensation => Salary + Bonus;

        public Employee(string name, int salary, int bonus) : base(name)
        {
            Salary = salary;
            Bonus = bonus;
        }
    }
}

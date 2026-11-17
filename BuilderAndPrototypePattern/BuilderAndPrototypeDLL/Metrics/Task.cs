using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototypeDLL.Metrics
{
    public class Task : VMetric
    {
        public string EmployeeName { get; private set; }
        public bool IsCompleted { get; private set; }

        public Task(string name, string employeeName, bool isCompleted) : base(name)
        {
            EmployeeName = employeeName;
            IsCompleted = isCompleted;
        }
    }
}

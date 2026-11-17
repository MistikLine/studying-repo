using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAndPrototypeDLL
{
    public class VMetric
    {
        public virtual string Name { get; protected set; }

        public VMetric(string name)
        {
            Name = name;
        }
    }
}

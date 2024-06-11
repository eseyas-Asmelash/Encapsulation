using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inhereditance
{
    internal class Pelican : Bird
    {
        public Pelican(string name, int age, double weight, int height, string uniqueProperty) 
            : base(name, age, weight, height, uniqueProperty)
        {
            this.UniqueProperty = uniqueProperty;
        }

    }
    internal class Flamingo : Bird
    {
        public Flamingo(string name, int age, double weight, int height, string uniqueProperty) 
            : base(name, age, weight, height, uniqueProperty)
        {
            this.UniqueProperty = uniqueProperty;
        }

    }
    internal class Swan : Bird
    {
        public Swan(string name, int age, double weight, int height, string uniqueProperty) : base(name, age, weight, height, uniqueProperty)
        {
            this.UniqueProperty = uniqueProperty;
        }

    }
}

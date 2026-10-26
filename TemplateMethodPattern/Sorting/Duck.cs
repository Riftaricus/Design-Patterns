using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern.CompareTo
{
    internal class Duck : IComparable
    {
        string name;
        int weight;

        public Duck(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public int CompareTo(object? obj)
        {
            if (obj is not Duck other) throw new ArgumentException("Object is not a duck.");

            return weight.CompareTo(other.weight);
        }

        public override string ToString()
        {
            return $"{name} weights {weight}";
        }
    }
}

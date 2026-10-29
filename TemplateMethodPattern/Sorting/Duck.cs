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
            //The basic method for sorting. Also works with alphabetical sorting for equal weights.
            // if (weight > other.weight)
            // {
            //     return -1;
            // }
            // else if (weight < other.weight)
            // {
            //     return 1;
            // }
            // else
            // {
            //     return name.CompareTo(other.name);
            // }

            
            // A combination of the above and the lower. It does organize lists when they're even.
            if (weight > other.weight || weight < other.weight)
            {
                return weight.CompareTo(other.weight) * -1;
            }
            else
            {
                return name.CompareTo(other.name);
            }

            //Another method, however doesn't alphabetically organize lists when they're even.
            return weight.CompareTo(other.weight) * -1;
        }

        public override string ToString()
        {
            return $"{name} weighs {weight}";
        }
    }
}

using System;
using System.Collections.Generic;

namespace Equality
{
    public class Program
    {
        static void Main(string[] args)
        {
            var slope1 = new Slope(1, 1, 1);
            var slope2 = new Slope(1, 2, 1);
            var slope3 = new Slope(1, 1, 1);

            Console.WriteLine("Show HashCode values");
            Console.WriteLine(slope1.GetHashCode());
            Console.WriteLine(slope2.GetHashCode());
            Console.WriteLine(slope3.GetHashCode());

            var hashSet = new HashSet<Slope>();
            Console.WriteLine("Try to add to HashSet");
            Console.WriteLine(hashSet.Add(slope1));
            Console.WriteLine(hashSet.Add(slope2));
            Console.WriteLine(hashSet.Add(slope3));

            Console.WriteLine("Show equals usage");
            Console.WriteLine(slope1.Equals(slope2));
            Console.WriteLine(slope1.Equals(slope3));

            Console.WriteLine("Show operator overloading");
            Console.WriteLine(slope1 == null);
            Console.WriteLine(null == slope1);
            Console.WriteLine(slope1 == slope2);
            Console.WriteLine(slope2 == slope1);
            Console.WriteLine(slope1 == slope3);
            Console.WriteLine(slope3 == slope1);
        }
    }
}
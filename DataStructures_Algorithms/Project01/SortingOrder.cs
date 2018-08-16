using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project01
{
    public class SortingOrder
    {
        public string Solve(string[] name, int[] age, int[] weight)
        {
            // Creating customer objects to mimic inplace sorting for the
            // [Name, Age, Weight] tuple
            Customer[] customers = new Customer[name.Length];
            for (int i = 0; i < name.Length; i++)
                customers[i] = new Customer(name[i], age[i], weight[i]);

            // Variables to keep track of type and
            // improve running time while reading
            bool[] isSorted = { false, false, false, false, false, false };
            string[] isSortedName = { "NAW", "NWA", "ANW", "AWN", "WAN", "WNA" };

            // Sorting in required possibilities with the Radix Sort dillema preserved,
            // (From LSD to MSD to get the correct sorting)
            Customer[] NAW = customers.OrderByDescending(c => c.weight).OrderBy(c => c.age).OrderBy(c => c.name).ToArray();
            Customer[] NWA = customers.OrderBy(c => c.age).OrderByDescending(c => c.weight).OrderBy(c => c.name).ToArray();
            Customer[] ANW = customers.OrderByDescending(c => c.weight).OrderBy(c => c.name).OrderBy(c => c.age).ToArray();
            Customer[] AWN = customers.OrderBy(c => c.name).OrderByDescending(c => c.weight).OrderBy(c => c.age).ToArray();
            Customer[] WAN = customers.OrderBy(c => c.name).OrderBy(c => c.age).OrderByDescending(c => c.weight).ToArray();
            Customer[] WNA = customers.OrderBy(c => c.age).OrderBy(c => c.name).OrderByDescending(c => c.weight).ToArray();

            // Checking which sort gives the input array
            if (ArrayEquals(NAW, customers)) isSorted[0] = true;
            if (ArrayEquals(NWA, customers)) isSorted[1] = true;
            if (ArrayEquals(ANW, customers)) isSorted[2] = true;
            if (ArrayEquals(AWN, customers)) isSorted[3] = true;
            if (ArrayEquals(WAN, customers)) isSorted[4] = true;
            if (ArrayEquals(WNA, customers)) isSorted[5] = true;

            // Returning correct type
            if (isSorted.Where(c => c).Count() == 0) return "NOT"; // if none of the type is used, NOT
            if (isSorted.Where(c => c).Count() > 1) return "IND"; // if more than one sorting gives same input array, INDterminant
            return (isSortedName[Array.IndexOf(isSorted, true)]); // If only one sorting gives the correct answer, getting the type with index
        }

        // Method to check Customer object arrays equality
        public static bool ArrayEquals(Customer[] a, Customer[] b)
        {
            for (int i = 0; i < a.Length; i++)
                if (!string.Equals(a[i].name, b[i].name) || (a[i].age != b[i].age) || (a[i].weight != b[i].weight))
                    return false;
            return true;
        }
    }

    public class Customer
    {
        public string name { get; set; }
        public int age { get; set; }
        public int weight { get; set; }

        public Customer(string name, int age, int weight)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
        }
    }
}

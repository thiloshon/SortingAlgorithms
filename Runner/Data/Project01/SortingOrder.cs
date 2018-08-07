using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Data.Project01
{
    class SortingOrder
    {
        public string Solve(string[] name, int[] age, int[] weight)
        {
            Customer[] customers = new Customer[name.Length];

            for (int i = 0; i < name.Length; i++)
                customers[i] = new Customer(name[i], age[i], weight[i]);

            bool[] isSorted = { false, false, false, false, false, false };
            string[] isSortedName = { "NAW", "NWA", "ANW", "AWN", "WAN", "WNA" };

            Customer[] NAW = customers.OrderByDescending(c => c.weight).OrderBy(c => c.age).OrderBy(c => c.name).ToArray();
            Customer[] NWA = customers.OrderBy(c => c.age).OrderByDescending(c => c.weight).OrderBy(c => c.name).ToArray();
            Customer[] ANW = customers.OrderByDescending(c => c.weight).OrderBy(c => c.name).OrderBy(c => c.age).ToArray();
            Customer[] AWN = customers.OrderBy(c => c.name).OrderByDescending(c => c.weight).OrderBy(c => c.age).ToArray();
            Customer[] WAN = customers.OrderBy(c => c.name).OrderBy(c => c.age).OrderByDescending(c => c.weight).ToArray();
            Customer[] WNA = customers.OrderBy(c => c.age).OrderBy(c => c.name).OrderByDescending(c => c.weight).ToArray();

            if (ArrayEquals(NAW, customers)) isSorted[0] = true;
            if (ArrayEquals(NWA, customers)) isSorted[1] = true;
            if (ArrayEquals(ANW, customers)) isSorted[2] = true;
            if (ArrayEquals(AWN, customers)) isSorted[3] = true;
            if (ArrayEquals(WAN, customers)) isSorted[4] = true;
            if (ArrayEquals(WNA, customers)) isSorted[5] = true;

            if (isSorted.Where(c => c).Count() == 0) return "NOT";
            if (isSorted.Where(c => c).Count() > 1) return "IND";
            return (isSortedName[Array.IndexOf(isSorted, true)]);
        }

        public static bool ArrayEquals(Customer[] a, Customer[] b)
        {
            for (int i = 0; i < a.Length; i++)
                if (!string.Equals(a[i].name, b[i].name) || (a[i].age != b[i].age) || (a[i].weight != b[i].weight))
                    return false;
            return true;
        }
    }
}

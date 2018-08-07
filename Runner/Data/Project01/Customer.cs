using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Data.Project01
{
    class Customer
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

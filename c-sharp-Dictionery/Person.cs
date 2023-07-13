using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_Dictionery
{
    internal class Person
    {
        public long id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public Person(long id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return ($"name:{name} age:{age}");
        }

       
    }
    
}

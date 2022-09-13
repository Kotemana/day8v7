using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8v7
{
    public class Animal : INamedEntity
    {
        public Animal() { }
        public Animal(string name)
        {
            Name = name;
        }
        public virtual string Name { get; set ; }

        public virtual void TellYourName()
        {
            Console.WriteLine($"My name is {Name}");
        }
        public int Weight { get; set; }
    }
}

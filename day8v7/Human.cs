using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day8v7
{
    public class Human : INamedEntity
    {
        public Human(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public void TellYourName()
        {
            Console.WriteLine($"Gamardjoba, my name is {Name}");
        }
        public void ChangeName(string newName)
        {
            Name = newName;
        }
        public int Iq { get; set; }
    }
}

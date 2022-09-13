

using day8v7.Hello;

namespace day8v7
{
    public sealed class Cat : Animal
    {
        public override void TellYourName()
        {
            Console.WriteLine($"I'm cat, My name is {Name}");
        }
        public string Color { get; set; }

        internal Hello2 MyProperty { get; set; }
    }
}

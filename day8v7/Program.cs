using day8v7;

var list = new List<INamedEntity>();
list.Add(new Animal() { Name = "Burenka", Weight = 100400 });
list.Add(new Cat() { Name = "Barsik", Weight = 100, Color = "Ginger" });

foreach (var named in list)
{
    named.TellYourName();
}
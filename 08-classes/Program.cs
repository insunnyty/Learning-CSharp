using _08_classes;

Animal monkey = new Animal("George")
{
    size = "medium",
    species = "Orangutan",
    age = "5"
};


Animal macaw = new Animal("Rio")
{
    size = "small",
    species = "Macaw",
    age = "3"
};

Animal giraffe = new Animal("Melman")
{
    size = "large",
    species = "Giraffe",
    age = "10"
};

monkey.Print();
macaw.Print();
giraffe.Print();

monkey.Eat();
macaw.Eat();
giraffe.Eat();

int distance = monkey.Move();
Console.WriteLine($"Distance moved by {monkey.name}: {distance} units.");

distance = macaw.Move();
Console.WriteLine($"Distance moved by {macaw.name}: {distance} units.");

distance = giraffe.Move();
Console.WriteLine($"Distance moved by {giraffe.name}: {distance} units.");

monkey.Play(macaw);
macaw.Play(giraffe);
giraffe.Play(monkey);
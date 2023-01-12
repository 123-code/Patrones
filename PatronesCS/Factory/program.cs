class Program
{
    static void Main(string[] args)
    {
        AnimalFactory factory = new AnimalFactory();
        IAnimals animal = factory.CreateAnimals("DOG");
        animal.Speak();
        // Output: Woof!
    }
}

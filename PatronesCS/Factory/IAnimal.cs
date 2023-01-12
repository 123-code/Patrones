public interface IAnimal
{
    void Speak();
}

public class Dog : IAnimals
{
    public void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : IAnimals
{
    public void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

public class AnimalFactory
{
    public IAnimals CreateAnimal(string animalType)
    {
        switch (animalType)
        {
            case "DOG":
                return new Dog();
            case "CAT":
                return new Cat();
            default:
                return null;
        }
    }
}

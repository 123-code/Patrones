﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronesDeDisenio
{
    public interface IAnimals
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
        public IAnimals CreateAnimals(string animalType)
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

}

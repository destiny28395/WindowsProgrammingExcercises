using System;
using System.Collections.Generic;
using Interface_Ex3.Model;

namespace Interface_Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            IList<IAnimal> animals = new List<IAnimal>();
            animals.Add(new Dog());
            animals.Add(new Cat("Meo meo"));
            animals.Add(new Monkey());
            animals.Add(new Dog("Gau gau", Common.Color.Black));
            foreach (var animal in animals)
            {
                animal.Move();
            }

            // Circus Show
            var dogTrainer = new trainer();
            foreach (var animal in animals)
            {
                if (animal is Dog)
                {
                    dogTrainer.Move(animal);
                }
            }
        }
    }
}

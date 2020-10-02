using System;
using System.Collections.Generic;
using System.Text;
using Interface_Ex3.Model;
namespace Interface_Ex3.Model
{
    public abstract class BaseAnimal : IAnimal
    {
        public BaseAnimal()
        {
            Birthdate = DateTime.Today;
        }

        public DateTime Birthdate { get; set; }

        public abstract void Move();

        public void Speak()
        {
            Console.WriteLine($"{this.GetType().Name} is speaking...");
        }
    }
}

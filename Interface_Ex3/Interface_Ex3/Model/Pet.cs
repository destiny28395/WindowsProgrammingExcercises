using System;
using System.Collections.Generic;
using System.Text;
using Interface_Ex3.Model;
namespace Interface_Ex3.Model
{
    public class Pet : BaseAnimal
    {
        public Pet(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override void Move()
        {
            Console.WriteLine($"{this.GetType().Name} '{Name}' is moving with four legs...");
        }
    }
}

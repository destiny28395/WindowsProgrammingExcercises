using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Ex3.Model
{
    public class Monkey : BaseAnimal
    {
        public Monkey()
        {
        }

        public void Climb()
        {
            Console.WriteLine($"{this.GetType().Name} is climbing...");
        }

        public override void Move()
        {
            Climb();
        }
    }
}

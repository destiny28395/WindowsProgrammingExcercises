using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Ex3.Model
{
    public class Cat : Pet
    {
        public Cat(string name) : base(name)
        {
        }

        public void Jump()
        {
            Console.WriteLine($"Cat '{Name}' is jumping...");
        }

        public override void Move()
        {
            base.Move();
            Jump();
        }
    }
}

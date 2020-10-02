using System;
using System.Collections.Generic;
using System.Text;
using Interface_Ex3.Common;

namespace Interface_Ex3.Model
{
    public class Dog : Pet
    {
        public Dog() : this("Kiki")
        {
        }

        public Dog(string name, Color color = Color.Yellow) : base(name)
        {
            Color = color;
        }

        public Color Color { get; set; }
    }
}

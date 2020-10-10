using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Ex3.Model
{
    public interface IAnimal
    {
        DateTime Birthdate { get; set; }
        void Move();
        void Speak();

    }
}

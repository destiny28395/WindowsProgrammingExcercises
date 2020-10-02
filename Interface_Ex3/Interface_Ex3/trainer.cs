using Interface_Ex3.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Ex3
{
    public class trainer
    {
        public trainer()
        {

        }
        public void Move(IAnimal animal)
        {
            animal.Move();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems3B
{
    public class Interfaceclass
    {
        // Interface
        interface IAnimal
        {
            void animalSound(); // interface method (does not have a body)
        }

        // Pig "implements" the IAnimal interface
        public class Pig : IAnimal
        {
            public void animalSound()
            {
                // The body of animalSound() is provided here
                Console.WriteLine("The pig says: wee wee");
            }
        }
    }
}

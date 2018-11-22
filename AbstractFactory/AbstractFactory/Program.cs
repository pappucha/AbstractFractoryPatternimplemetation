using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Factory;


namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory animalFactory = null;
            string Speak = null;
            animalFactory = AnimalFactory.GetAnimalFactory("sea");
            animal = animalFactory.getAnimal("Shark");
            Speak = animal.Speak();
            





        }
    }
}

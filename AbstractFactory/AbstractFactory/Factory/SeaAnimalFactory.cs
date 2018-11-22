using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal getAnimal(string animalType)
        {
            IAnimal animal = null;
            if("Shark".Equals(animalType))
            {
                animal = new Shark();
            }
            else
            {
                animal = new Octopus();
            }
            return animal;
        }
    }
}

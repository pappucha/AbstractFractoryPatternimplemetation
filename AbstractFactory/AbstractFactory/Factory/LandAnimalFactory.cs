using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal getAnimal(string animalType)
        {
            IAnimal animal = null;
            if("Lion".Equals(animalType))
            {
                animal = new Lion();
            }
            else if("Dog".Equals(animalType))
            {
                animal = new Dog();

            }
            else if ("Cat".Equals(animalType))
            {
                animal = new Cat();

            }
            return animal;
            

        }
    }
}

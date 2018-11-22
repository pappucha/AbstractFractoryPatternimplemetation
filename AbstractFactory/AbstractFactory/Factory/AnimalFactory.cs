using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public abstract class AnimalFactory
    {
        public abstract IAnimal getAnimal(string animalType);

        public static AnimalFactory GetAnimalFactory(string factoryType)
        {
            AnimalFactory animalFactory = null;
            if("sea".Equals(factoryType))
            {
                animalFactory = new SeaAnimalFactory();
            }
            else
            {
                animalFactory = new LandAnimalFactory();
            }

            return animalFactory;
        }




    }
}

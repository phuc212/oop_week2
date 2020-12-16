using System;

namespace lớp_Animal_và_interface_Edible
{
   class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.MakeSound());
                if(animal is Chicken)
                {
                    Edible edible = (Chicken)animal;
                    Console.WriteLine(edible.Howtoeat());
                }
            }
            Fruit[] fruits = new Fruit[2];
            fruits[0] = new orange();
            fruits[1] = new Apple();
          foreach (var item in fruits)
          {
              Console.WriteLine(item.Howtoeat());
          }
           
        }
    }
}

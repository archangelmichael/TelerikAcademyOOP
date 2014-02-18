using System;
namespace DescribeAnimals
{
    /* 
     * Task 3
     * Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
     * Dogs, frogs and cats are Animals. 
     * All animals can produce sound (specified by the ISound interface). 
     * Kittens and tomcats are cats. 
     * All animals are described by age, name and sex. 
     * Kittens can be only female and tomcats can be only male. 
     * Each animal produces a specific sound. 
     * Create arrays of different kinds of animals and calculate the average age 
     * of each kind of animal using a static method (you may use LINQ).
    */

    class Program
    {
        static void Main()
        {
            Dog dog = new Dog("Emi", 1);
            Console.WriteLine("{0} says: {1}", dog.Name, dog.MakeSound());
            Frog frog = new Frog("Ram", 3);
            Console.WriteLine("{0} says: {1}", frog.Name, frog.MakeSound());
            Tomcat tomcat = new Tomcat("Tom", 5);
            Console.WriteLine("{0} says: {1}", tomcat.Name, tomcat.MakeSound());
           
            Animal[] animals = 
            {
                 new Dog("Balkan", 3),
                 new Cat("Sindy", 2), 
                 new Tomcat("Bob", 10),
                 new Dog("Shako", 11),
                 new Frog("Bogy", 4),
                 new Frog("Taro", 7),
                 new Dog("Baro", 0), 
                 new Cat("Jaffy", 18), 
                 new Tomcat("Kosta", 5),
                 new Dog("Huskvarna", 7), 
                 new Dog("Bobcho", 5),
                 new Tomcat("Kingo", 8),
                 new Kitten("Kitty", 3), 
                 new Kitten("Cait", 7),
                 new Frog("Ram", 3)
            };

            var averageAges = Animal.AverageAge(animals);

            foreach (var typeAnimal in averageAges)
            {
                Console.WriteLine("Animal: {0} with average age: {1:F1}.", typeAnimal.Item1, typeAnimal.Item2);
            }


        }
    }
}

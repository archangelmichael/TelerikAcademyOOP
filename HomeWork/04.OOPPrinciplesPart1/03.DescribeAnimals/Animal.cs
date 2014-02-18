namespace DescribeAnimals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Animal
    {
        //Fields
        private int age;
        private string name;
        private Gender sex;

        //Constructors
        public Animal(string name, int age)
            : this(name, age, Gender.male)
        {
        }
        public Animal(string name, int age, Gender sex)
        {
            this.Name = name;
            this.Age = age;
            this.sex = sex;
        }

        //Properties
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != string.Empty && value.Length >= 2)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid name!");
                }
            }
        }
        public int Age
        {
            get { return this.age; }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Invalid age! (must be between 0 and 20 including)");
                }
            }
        }
        public Gender Sex
        {
            get { return this.sex; }
            set { this.sex = value; }
        }

        //Methods
        public static IEnumerable<Tuple<string, double>> AverageAge(Animal[] animals) //Get every kind of animal in separate group and calculate average
        {
            var averageAges =
                from animal in animals
                group animal by animal.GetType() into animalType
                select new Tuple<string, double>(animalType.Key.Name, animalType.Average(a => a.Age));

            return averageAges;
        }    
    }
}

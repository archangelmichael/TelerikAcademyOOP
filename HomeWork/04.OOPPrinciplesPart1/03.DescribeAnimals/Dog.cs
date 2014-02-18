namespace DescribeAnimals
{
    
    public class Dog : Animal, ISound
    {
        //Constructors
        public Dog(string name, int age)
            : base(name, age)
        {
        }
        public Dog(string name, int age, Gender sex)
            : base(name, age, sex)
        {
        }

        //Methods
        public string MakeSound()
        {
            return "Djaf, djaf!";
        }
    }
}

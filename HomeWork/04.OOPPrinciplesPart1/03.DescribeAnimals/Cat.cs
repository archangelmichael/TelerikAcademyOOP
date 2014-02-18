namespace DescribeAnimals
{
    public class Cat : Animal, ISound
    {
        //Constructors
        public Cat(string name, int age)
            : base(name, age)
        {
        }

        public Cat(string name, int age, Gender sex)
            : base(name, age, sex)
        {
        }

        //Methods
        public virtual string MakeSound()
        {
            return "Miau, miau!";
        }
    }
}

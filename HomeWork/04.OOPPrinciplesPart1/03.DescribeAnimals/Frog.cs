namespace DescribeAnimals
{
    public class Frog : Animal, ISound
    {
        //Constructors
        public Frog(string name, int age)
            : base(name, age)
        {
        }
        public Frog(string name, int age, Gender sex)
            : base(name, age, sex)
        {
        }

        //Methods
        public string MakeSound()
        {
            return "Crock, crock!";
        }
    }
}

namespace DescribeAnimals
{
    public class Kitten : Cat
    {
        //Constructors
        public Kitten(string name, int age)
            : base(name, age, Gender.female)
        {
        }

        //Properties
        public new Gender Sex
        {
            get { return base.Sex; }
            private set { }  // property will be always female
        }

        //Methods
        public override string MakeSound()
        {
            return "Mrrr, mrrr!";
        }
    }
}

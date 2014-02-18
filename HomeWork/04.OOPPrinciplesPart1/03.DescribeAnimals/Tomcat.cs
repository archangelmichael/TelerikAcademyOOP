namespace DescribeAnimals
{
    public class Tomcat : Cat
    {
        //Constructors
        public Tomcat(string name, int age)
            : base(name, age, Gender.male)
        {
        }

        //Property
        public new Gender Sex
        {
            get { return base.Sex; }
            private set { }  // property will be always male
        }

        //Methods
        public override string MakeSound()
        {
            return "Roar, roar!";
        }


    }
}

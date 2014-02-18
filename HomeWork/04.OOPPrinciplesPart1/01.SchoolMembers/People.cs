namespace SchoolMembers
{
    public class People
    {
        //Field
        private string name;

        //Property
        public string Name
        { 
            get { return this.name; } 
            set 
            { 
                // Can check if you are authorised to change the name for protection
                this.name = value; 
            } 
        }

        //Constructor
        public People() : this("unnamed")
        {
        }
        public People(string personName)
        {
            this.name = personName;
        }
    }
}

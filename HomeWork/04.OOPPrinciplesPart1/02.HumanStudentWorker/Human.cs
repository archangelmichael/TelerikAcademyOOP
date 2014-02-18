namespace HumanStudentWorker
{
    using System;
    public abstract class Human
    {
        //Fields
        private readonly string firstName;
        private readonly string lastName;
       
        //Properties
        protected string FirstName { get { return this.firstName; } }
        protected string LastName { get { return this.lastName; } }

        //Constructors
        protected Human(string name, string surname)
        {
            if (name != string.Empty && name.Length >= 2)
            {
                this.firstName = name;
            }
            else
            {
                throw new ArgumentException("First name can't be empty!");
            }

            if (surname != string.Empty && surname.Length >= 2)
            {
                this.lastName = surname;
            }
            else
            {
                throw new ArgumentException("Last name can't be empty!");
            }           
        }

        //Methods  make abstract method in order to make the class abstract
        public abstract string GetFirstName();
        public abstract string GetLastName();
    }
}

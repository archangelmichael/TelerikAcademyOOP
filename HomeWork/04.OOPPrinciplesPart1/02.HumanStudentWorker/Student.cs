namespace HumanStudentWorker
{
    using System;

    class Student : Human
    {
        //Fields
        private int grade;
        
        //Properties
        public int Grade
        {
            get
            { return this.grade; }
            set
            {
                if (value > 0 && value < 13)
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentException("The grade must be between 1 and 12 including!");
                }
            }
        }

        //Constructors
        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.grade = grade;
        }

        //Methods
        public override string GetFirstName()
        {
            return this.FirstName;
        }
        public override string GetLastName()
        {
            return this.LastName;
        }
        public override string ToString()
        {
            return string.Format("{0} {1}  studies in  {2} grade.",
                GetFirstName(), GetLastName(), this.grade);
        }
    }
}

namespace SchoolMembers
{
    using System.Collections.Generic;

    public class Student : People,IComment
    {
        //Fields
        private long uniqueNumber;

        //Properties
        public long UniqueNumber
        {
            get { return uniqueNumber; }
            set 
            { 
                //Can check if authorized to change it for protection
                uniqueNumber = value; 
            }
        }
        public List<string> Comments { get; set; }

        //Constructors
        public Student()
            : base()
        {
        }
        public Student(string studentName) : base(studentName)
        {
        }
        public Student(string studentName, long uniqueStudentNumber)
            : base(studentName)
        {
            this.uniqueNumber = uniqueStudentNumber;
        }

        //Methods
        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}

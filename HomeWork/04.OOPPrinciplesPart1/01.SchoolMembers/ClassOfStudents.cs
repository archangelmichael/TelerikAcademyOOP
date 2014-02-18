namespace SchoolMembers
{
    using System.Collections.Generic;

    public class ClassOfStudents:IComment
    {
        //Fields
        private List<Teacher> teachers;
        private List<Student> students;
        private string classID;

        //Properties
        public string ClassID { get; set; }
        public List<string> Comments { get; set; }

        //Constructors
        public ClassOfStudents(string ClassID)
        {
            this.ClassID = ClassID;
            this.teachers = new List<Teacher>();
            this.students = new List<Student>();          
        }

        //Methods
        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}

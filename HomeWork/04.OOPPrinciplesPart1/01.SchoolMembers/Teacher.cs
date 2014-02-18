namespace SchoolMembers
{
    using System.Collections.Generic;

    public class Teacher : People,IComment
    {
        //Fields
        private List<Disciplines> disciplines;

        //Properties
        public List<string> Comments { get; set; }
        public List<Disciplines> Disciplines { get; set; }

        //Constructors
        public Teacher()
            : base()
        {
            this.Disciplines = new List<Disciplines>();
        }
        public Teacher(string teacherName)
            : base(teacherName)
        {
            this.Disciplines = new List<Disciplines>();
        }

        //Methods
        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}

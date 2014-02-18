namespace SchoolMembers
{
    using System.Collections.Generic;

    public class Disciplines : IComment
    {
        //Fields
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExercises;
        public List<string> Comments { get; set; }
        //Properties
        public string DisciplineName
        {
            get { return disciplineName; }
            set { disciplineName = value; }
        }
        public int NumberOfExercises
        {
            get { return numberOfExercises; }
            set { numberOfExercises = value; }
        }
        public int NumberOfLectures
        {
            get { return numberOfLectures; }
            set { numberOfLectures = value; }
        }
        //Constructors
        public Disciplines():this("unknown",0,0)
        {
        }
        public Disciplines(string name, int lectures, int exercises)
        {
            this.disciplineName = name;
            this.numberOfLectures = lectures;
            this.NumberOfExercises = exercises;
        }
        //Methods
        public void AddComment(string comment)
        {
            Comments.Add(comment);
        }
    }
}

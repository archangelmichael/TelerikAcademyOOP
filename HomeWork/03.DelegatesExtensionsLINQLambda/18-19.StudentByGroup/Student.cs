using System;
namespace StudentByGroup
{
    public class Student
    {
        private string name;
        private string groupName;

        public Student(string name, string group)
        {
            this.name = name;
            this.groupName = group;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.name = value;
            }
        }

        public string GroupName
        {
            get
            {
                return this.groupName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name!");
                }
                this.groupName = value;
            }
        }

        public override string ToString()
        {
 	         return string.Format("{0} is in {1}!",this.name, this.groupName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Students
{
    public class Student
    {
        //Fields
        private string firstName;
        private string lastName;
        private string fN;
        private string tel;
        private string email;
        private List<int> marks;
        private uint groupNumber;

        //Constructor
        public Student(string fName, string lName, string fn, string tel, string email, uint groupNumber, params int[] inputMarks)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.fN = fn;
            this.tel = tel;
            this.email = email;
            this.groupNumber = groupNumber;
            this.marks = new List<int>(inputMarks);
        }

        //Properties
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be null or empty !");
                }
                this.firstName = value; 
            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be null or empty !");
                } 
                this.lastName = value;
            }
        }
        public string FN
        {
            get { return fN; }
            set  // check for appropriate fac number
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Faculty number can not be null or empty !");
                }
                if (!Regex.IsMatch(value, @"([0-9]{8})"))
                {
                    throw new ApplicationException("Faculty number is a 8 digits number !");
                } 
                this.fN = value;
            }
        }
        public string Tel
        {
            get { return tel; }
            set   //Check for valid telephone
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Telephones can not be null or empty !");
                }
                if (!Regex.IsMatch(value, @"(\+359[0-9]{9})") && !Regex.IsMatch(value, @"(0[0-9]{9})"))
                {
                    throw new ApplicationException("Telephones begin with +359 / 0 followed by 9 digits !");
                } 
                this.tel = value;
            }
        }
        public string Email
        {
            get { return email; }
            set   //Check for valid email
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email can not be null or empty !");
                }
                if (!Regex.IsMatch(value, @"[\w., \-]{2,20}@[\w]{2,20}[.]{1}[\w.]{2,6}"))
                {
                    throw new ApplicationException("Email must be valid !");
                }
                this.email = value;
            }
        }
        public uint GroupNumber
        {
            get { return groupNumber; }
            set
            {
                if (value < 1)
                {
                    throw new ApplicationException("Group number must be > 0 !");
                }
                this.groupNumber = value;
            }
        }
        public List<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }
        }
        public Group Group { get; set; }

        //Methods
        public void AddMark(int currMark)
        {
            if (currMark < 1 || currMark > 6)
            {
                throw new ApplicationException("Marks are between 1 and 6 !");
            }
            this.marks.Add(currMark);
        }
        public void RemoveMarkAtPosition(int position)
        {
            if (position < 0 || position >= this.marks.Count)
            {
                throw new ApplicationException("Invalid mark position!");
            }
            this.marks.RemoveAt(position);
        }
        public void RemoveMark(int currMark)
        {
            if (!this.marks.Contains(currMark))
            {
                throw new ApplicationException("Invalid mark value!");
            }
            this.marks.Remove(currMark);
        }
        public override string ToString()
        {
            var result = new StringBuilder();

            //using reflection to get all the properties by name and value
            var properties = this.GetType().GetProperties();

            result.AppendLine(new string('-', 40));

            foreach (var property in properties)
            {
                if (property.Name == "Marks" || property.Name == "Group")
                {
                    continue;
                }
                result.AppendFormat("{0}: {1}", property.Name.PadLeft(15), property.GetValue(this, null));
                result.AppendLine();
            }

            result.Append("Marks: ".PadLeft(17));
            result.AppendFormat(string.Join(", ", this.Marks));

            return result.ToString();
        }
        
    }
}

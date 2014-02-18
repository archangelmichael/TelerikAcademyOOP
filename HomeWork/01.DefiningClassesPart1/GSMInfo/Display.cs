namespace GSMInfo
{
    using System;
    public class Display
    {
        // Fields Task 1
        private double? size;
        private int? numberOfColors;

        // Constructors  Task 2
        public Display() : this(0,256)
        {
        }
        public Display(double? size)  : this(size, 0)
        {
        }
        public Display(double? size, int numberOfColors)
        {
            if (size < 0) // Task 5
            {
                throw new ArgumentException("Invalid display size!");
            }
            else
            {
                this.size = size;
            }
            if (numberOfColors < 0)  //Task 5
            {
                throw new ArgumentException("Invalid number of colors!");
            }
            else
            {
                this.numberOfColors = numberOfColors;
            }
        }
        
        //Properties   implement task 5
        public double? Size
        {
            get { return this.size; }
            set 
            {
                if (size < 0) // Task 5
                {
                    throw new ArgumentException("Invalid display size!");
                }
                else
                {
                    this.size = value;
                }
            }
        }
        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set 
            {
                if (value < 0)  // Task 5
                {
                    throw new ArgumentException("Invalid number of colors!");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }
    }
}

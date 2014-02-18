namespace Point3D
{
    using System;

/*
 * Task 1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} 
 * in the Euclidian 3D space. 
 * Implement the ToString() to enable printing a 3D point.

 * Task 2. Add a private static read-only field to hold 
 * the start of the coordinate system – the point O{0, 0, 0}. 
 * Add a static property to return the point O.

 * Task 3. Write a static class with a static method to calculate the distance 
 * between two points in the 3D space.

 * Task 4. Create a class Path to hold a sequence of points in the 3D space.
 * Create a static class PathStorage with static methods to save and load paths 
 * from a text file. Use a file format of your choice.
*/

    public class Test3DPoint
    {
        public static void Main()
        {
            Test1and2and3();

            Test4();
        }

        public static void Test4()
        {
            Path test1 = new Path();
            test1.AddPoint();
            test1.AddPoint(new Point(1, 2, 3));
            test1.AddPoint(4, 5, 6);


            Console.WriteLine(test1); // testing toString for a path

            PathStorage.WritePathToFile("../../testing.txt", test1);

            Path readFromFile = PathStorage.ReadPathFromFile("../../input.txt");

            Console.WriteLine(readFromFile);
        }

        public static void Test1and2and3()
        {
            Point test1 = new Point(1, 2, 3);
            Point test2 = new Point(2, 3, 4);

            Console.WriteLine(test1);
            Console.WriteLine(test2);

            Console.WriteLine(Point.Start);

            Console.WriteLine(Distance.CalculateDistance(test1, test2));
        }
    }
}
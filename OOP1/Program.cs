namespace Assignment__1__OOP
{
    internal class Program
    {
        public enum WeekDays
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        public enum Season
        {
            Spring, Summer, Autumn, Winter
        }
        [Flags]
        public enum Permissions
        {
            Read = 1, write = 2, Delete = 4, Execute = 8
        }
        class user
        {
            public Permissions permission;
        }
        public enum Colors
        {
            Red, Green, Blue
        }

        static void Main(string[] args)
        {
            #region 1
            ////Create an enum called "WeekDays" with the days of the week(Monday to Sunday) as its members.Then
            ////write a C# program that prints out all the days of the week using this enum.

            //for (int i = 0; i < 7; i++) {
            //    WeekDays x = (WeekDays)i;
            //    Console.WriteLine(x);
            //}

            #endregion

            #region 2

            ////Create an enum called "Season" with the four seasons(Spring, Summer, Autumn, Winter) as its members
            ////Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season
            ////Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            //string s = Console.ReadLine();
            //if (Enum.TryParse(s, out Season enumSeason))
            //{
            //    switch (enumSeason)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("March to May");
            //            break;
            //        case Season.Summer:
            //           Console.WriteLine("June to August");
            //            break;
            //        case Season.Autumn:
            //           Console.WriteLine("September to November");
            //            break;
            //        case Season.Winter:
            //           Console.WriteLine("December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season.");
            //}


            #endregion

            #region 3
            ////Assign the following Permissions(Read, write, Delete, Execute) in a form of Enum.
            ////Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable

            //user u = new user();
            //u.permission = (Permissions)1;
            //Console.WriteLine(u.permission);
            //Console.WriteLine("Adding Delete Permission ....");
            //u.permission = u.permission ^ Permissions.Delete;
            //Console.WriteLine(u.permission);
            //Console.WriteLine("Removing Delete Permission ....");
            //u.permission = u.permission ^ Permissions.Delete;
            //Console.WriteLine(u.permission);
            //Console.WriteLine("Checking if user has Read Permission ....");
            //if ((u.permission & Permissions.Read) == Permissions.Read)
            //{
            //    Console.WriteLine("User has Read Permission");
            //}
            //else
            //{
            //    Console.WriteLine("User Doesn't have Read Permission");
            //}
            //Console.WriteLine("Checking if user has Delete Permission ....");
            //if ((u.permission & Permissions.Delete) == Permissions.Delete)
            //{
            //    Console.WriteLine("User has Delete Permission");
            //}
            //else
            //{
            //    Console.WriteLine("User Doesn't have Delete Permission");
            //}

            #endregion

            #region 4

            ////Create an enum called "Colors" with the basic colors(Red, Green, Blue) as its members
            ////Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not

            //Console.WriteLine("Enter your Color");
            //string c = Console.ReadLine();
            //if (Enum.TryParse<Colors>(c,true, out Colors color))
            //{
            //  Console.WriteLine("Primary Color");    
            //}
            //else {Console.WriteLine("Not Primary Color"); }

            #endregion

            #region 5

            ////Create a struct called "Point" to represent a 2D point with properties "X" and "Y" 
            ////Write a C# program that takes two points as input from the user and calculates the distance between them.

            //point p1;
            //point p2;
            //double D = 0;
            //Console.WriteLine("Enter the first point");
            //p1.X = int.Parse(Console.ReadLine());
            //p1.Y = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the Second point");
            //p2.X = int.Parse(Console.ReadLine());
            //p2.Y = int.Parse(Console.ReadLine());
            //int dx = p2.X - p1.X;
            //int dy = p2.Y - p1.Y;
            //D=Math.Sqrt(dx * dx + dy * dy);
            //Console.WriteLine("The Distence is "+D);

            #endregion

        }
    }
}

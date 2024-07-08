namespace Assignment
{
    internal class Program
    {
        enum WeekDays : byte
        {
            Sunday = 1,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        enum Season : byte
        {
            Spring = 1,
            Summer = 3,
            Autumn = 5,
            Winter = 7
        }
        enum Month : byte
        {
            March = 1,
            May,
            June,
            August,
            September,
            November,
            December,
            february
        }

        [Flags]
        enum Permissions : byte
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        enum Colors
        {
            Red,
            Green,
            Blue,
        }

        static void Main(string[] args)
        {

            #region Question 1

            //foreach (var day in Enum.GetNames(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}


            #endregion


            #region Question 2

            //Person[] person = new Person[5];
            //person[0] = new Person();
            //person[1] = new Person();

            //person[0].Name = "Mahmoud";
            //person[0].Age = 21;

            //person[1].Name = "Ahmed";
            //person[1].Age = 31;

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"Name: {person[i].Name}\nAge: {person[i].Age}\n");
            //}

            #endregion


            #region Question 3

            //Season season = new Season();

            //Console.Write("Enter Your Season: ");

            //Enum.TryParse(Console.ReadLine(), true, out season);

            //Month month = new Month();

            //month = (Month)(int)season;

            //Console.WriteLine($"\n({season}) from {month} to {++month} ");

            #endregion


            #region Question 4

            //Permissions permission = new Permissions();

            //while (true)
            //{
            //    Console.Clear();
            //    Console.Write("Enter (1) if you want to add Permissions\nEnter (2) if you want to remove Permissions\nEnter (3) if you want to check Exist Permissions\nEnter (another thing) to Exit the program: ");

            //    int check = int.Parse(Console.ReadLine() ?? "0");


            //    if (check == 1)
            //    {
            //        while (true)
            //        {
            //            Console.Clear();

            //            Console.WriteLine("Please Enter the Permission or Enter -1 to Exit the Program");

            //            Console.WriteLine("\n-------------------------------------------\n");

            //            Console.WriteLine("1. Enter (1 or Read) to add Read Permission");
            //            Console.WriteLine("2. Enter (2 or Write) to add Write Permission");
            //            Console.WriteLine("3. Enter (3 or Delete) to add Delete Permission");
            //            Console.WriteLine("4. Enter (4 or Execute) to add Execute Permission");

            //            Console.WriteLine("\n-------------------------------------------\n");

            //            Console.WriteLine("# (important)\n Entering number equal summition of two Permissions the two Permissions will added (Enter 3 will add 'Read and Write')");

            //            Console.WriteLine("\n-------------------------------------------\n");

            //            string word = Console.ReadLine() ?? "0";

            //            int number;

            //            if (int.TryParse(word, out number) && number > 0)
            //                permission |= (Permissions)number;
            //            else if (number == -1)
            //                break;
            //            else
            //                permission |= Enum.Parse<Permissions>(word, true);

            //        }

            //    }
            //    else if (check == 2)
            //    {
            //        while (true)
            //        {
            //            Console.Clear();

            //            Console.WriteLine("Please Enter the Permission or Enter -1 to Exit the Program");

            //            Console.WriteLine("\n-------------------------------------------\n");

            //            Console.WriteLine("1. Enter (1 or Read) to Remove Read Permission");
            //            Console.WriteLine("2. Enter (2 or Write) to Remove Write Permission");
            //            Console.WriteLine("3. Enter (3 or Delete) to Remove Delete Permission");
            //            Console.WriteLine("4. Enter (4 or Execute) to Remove Execute Permission");

            //            Console.WriteLine("\n-------------------------------------------\n");

            //            Console.WriteLine("# (important)\n Entering number equal summition of two Permissions the two Permissions will Removed (Enter 3 will Remove 'Read and Write')");

            //            Console.WriteLine("\n-------------------------------------------\n");

            //            string word = Console.ReadLine() ?? "0";

            //            int number;

            //            if (int.TryParse(word, out number) && number > 0)
            //                permission -= (Permissions)number;
            //            else if (number == -1)
            //                break;
            //            else
            //                permission -= Enum.Parse<Permissions>(word, true);

            //        }
            //    }
            //    else if (check == 3)
            //    {

            //        Console.Clear();
            //        while (true)
            //        {

            //            Console.WriteLine("Please Enter the Permission or Enter -1 to Exit the Program");

            //            Console.WriteLine("\n-------------------------------------------\n");

            //            Console.WriteLine("1. Enter (1 or Read) to Check if Read Permission is Exist");
            //            Console.WriteLine("2. Enter (2 or Write) to Check if Write Permission is Exist");
            //            Console.WriteLine("3. Enter (3 or Delete) to Check if Delete Permission is Exist");
            //            Console.WriteLine("4. Enter (4 or Execute) to Check if Execute Permission is Exist");

            //            Console.WriteLine("\n-------------------------------------------\n");

            //            Console.WriteLine("# (important)\n Entering number equal summition of two Permissions the two Permissions will Checked (Enter 3 will Check if 'Read and Write' are Exist)");

            //            Console.WriteLine("\n-------------------------------------------\n");

            //            string word = Console.ReadLine() ?? "0";
            //            int number;
            //            Console.Clear();


            //            if (int.TryParse(word, out number) && number > 0)
            //            {
            //                if (permission.HasFlag((Permissions)number))
            //                    Console.WriteLine($"Yes permission {(Permissions)number} is Exists");
            //                else
            //                    Console.WriteLine($"No permission {(Permissions)number} isn't Exists");
            //            }
            //            else if (number == -1)
            //                break;
            //            else
            //            {
            //                if (permission.HasFlag(Enum.Parse<Permissions>(word, true)))
            //                    Console.WriteLine($"Yes permission {Enum.Parse<Permissions>(word, true)} is Exists");
            //                else
            //                    Console.WriteLine($"No permission {Enum.Parse<Permissions>(word, true)} isn't Exists");
            //            }
            //            Console.WriteLine("\n");
            //        }


            //    }
            //    else
            //    { break; }
            //}

            #endregion


            #region Question 5

            //Console.Write("Enter a Color: ");

            //Colors color = new Colors();

            //string input = Console.ReadLine() ?? "";

            //if (Enum.TryParse(input, true, out color))
            //    Console.WriteLine($"{input} is Primary Color");
            //else
            //    Console.WriteLine($"{input} is not Primary Color");

            #endregion


            #region Question 6

            Point p1 = new Point();

            Point p2 = new Point();

            Console.WriteLine("Enter the (x,y) of the first Point: ");



            p1.X = int.Parse(Console.ReadLine() ?? "0");


            p1.Y = int.Parse(Console.ReadLine() ?? "0");



            Console.WriteLine("Enter the (x,y) of the second Point: ");


            p2.X = int.Parse(Console.ReadLine() ?? "0");

            p2.Y = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine($"Point 1 = ({p1.X},{p1.Y})\n");

            Console.WriteLine($"Point 2 = ({p2.X},{p2.Y})\n");

            if (p1.X == p2.X)
                Console.WriteLine($"The Distance = {Math.Abs(p1.Y - p2.Y)}");
            else if (p1.Y == p2.Y)
                Console.WriteLine($"The Distance = {Math.Abs(p1.X - p2.X)}");
            else
            {
                int powX = (p1.X - p2.X) * (p1.X - p2.X);
                int powY = (p1.Y - p2.Y) * (p1.Y - p2.Y);
                Console.WriteLine($"The Distance = {Math.Sqrt(powX + powY)}");
            }


            #endregion





        }
    }
}

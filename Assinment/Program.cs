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

            Season season = new Season();

            Console.Write("Enter Your Season: ");

            Enum.TryParse(Console.ReadLine(), true, out season);

            Month month = new Month();

            month = (Month)(int)season;

            Console.WriteLine($"\n({season}) from {month} to {++month} ");

            #endregion

        }
    }
}

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

            foreach (var day in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }


            #endregion




        }
    }
}

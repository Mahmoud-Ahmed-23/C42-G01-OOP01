using Common;


namespace Demo
{

    class person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }

    enum Grade
    {
        // Lables
        A,
        B,
        C,
        D,
        E,
        F
    }

    enum Gender
    {
        male,
        female
    }

    [Flags]
    enum Permissions : byte
    {
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }


    internal class Program
    {
        static void Main(string[] args)
        {



            #region Access Modifires [Private, Internal, Public]

            //TypeA obj = new TypeA();

            ////obj.x = 10; invalid due to it's protection level [X is private]

            ////obj.y = 5;  invalid due to it's protection level [X is internal]

            ////obj.z = 15; valid due to it's protection level [X is public] 

            #endregion


            #region Enum


            #region Example 1
            //Grade grade = new Grade();

            //grade = Grade.A;

            //if (grade == Grade.A)
            //    Console.WriteLine(":)");
            //else
            //    Console.WriteLine(":(");


            //grade = (Grade)5;

            //Console.WriteLine(grade); 
            #endregion


            #region Example 2

            //Gender gender;

            //gender = (Gender)Enum.Parse(typeof(Gender), Console.ReadLine() ?? ""); // Boxing

            //gender = Enum.Parse<Gender>(Console.ReadLine() ?? ""); // Not Boxing


            //Console.WriteLine(gender);


            //Enum.TryParse(typeof(Gender), Console.ReadLine(), out object? obj);

            //Enum.TryParse/*<Gender>*/(Console.ReadLine(), out gender);


            //Console.WriteLine(gender);


            #endregion


            #region Flag Enum

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


            #endregion


            #region Struct

            //Point p1;

            //p1 = new Point(1, 2);

            //p1.x = 1;
            //p1.y = 2;


            //Console.WriteLine(p1.x);
            //Console.WriteLine(p1.y);

            //Console.WriteLine(p1.ToString());

            #endregion


            #region Encapsulation

            //Person person;

            //person = new Person();

            //person.Salary = 9_000;

            //person.Id = 1;

            //person.Name = "Mahmoud";

            //Console.WriteLine(person);

            #endregion


            #region Indexer

            PhoneBook note = new PhoneBook(3);

            note.AddPerson(0, "Ahmed", 1);

            note.AddPerson(1, "Aya", 2);

            note.AddPerson(2, "Omar", 3);


            Console.WriteLine(note["Ahmed"]);


            for (int i = 0; i < note.Size; i++)
            {
                Console.WriteLine(note[i]);
            }




            #endregion




        }
    }
}

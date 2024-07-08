using System.Reflection;

namespace Task
{
    internal class Program
    {

        static void SetValues(ref Employee employee)
        {
            bool flag = true;
            do
            {
                Console.Write("Please Enter Your Id: ");

                int id;

                flag = int.TryParse(Console.ReadLine(), out id) && id != 0;

                if (flag)
                    employee.Id = id;
            }
            while (!flag);


            do
            {
                Console.Write("Please Enter Your Name: ");

                employee.Name = Console.ReadLine() ?? "";

                char[] name = employee.Name.ToCharArray();

                flag = true;

                foreach (char c in name)
                {
                    if (!char.IsLetter(c))
                    {
                        flag = false;
                        break;
                    }
                }

            } while (!flag);



            do
            {
                Console.Write("Please Enter Your Salary: ");

                decimal salary;

                flag = decimal.TryParse(Console.ReadLine(), out salary);

                if (flag)
                    employee.Salary = salary;

            }
            while (!flag);



            do
            {
                Console.Write("Please Enter Your Gender: ");
                Gender gender;
                flag = Enum.TryParse(Console.ReadLine(), true, out gender);
                if (flag)
                    employee.Gender = gender;
            }
            while (!flag);

        }
        static void GetValues(Employee employee)
        {
            Console.WriteLine("\n-------------------------------\n");

            Console.WriteLine($"Id: {employee.Id}");

            Console.WriteLine($"Name: {employee.Name}");

            Console.WriteLine($"Salary: {employee.Salary:c}");

            Console.WriteLine($"Gender: {employee.Gender}");
        }
        static void Main(string[] args)
        {

            Employee employee = new Employee("Fatma", 19, 4_000, Enum.Parse<Gender>("Female", true));


            SetValues(ref employee);


            GetValues(employee);

        }
    }
}

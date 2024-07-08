using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{

    enum Gender
    {
        Male,
        Female
    }
    internal struct Employee
    {


        private string? name;

        private int id;

        private decimal salary;

        private Gender gender;




        public Employee(string name, int id, decimal salary, Gender gender)
        {
            this.name = name;

            this.id = id;

            this.salary = salary;

            Gender = gender;

        }

        public string Name
        {
            get { return name ?? ""; }
            set { name = value; }
        }


        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }


        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }


        public override string ToString()
        {
            return $"Id: {id}\nName: {name}\nSalary: {salary} \nGender: {Gender}";
        }




    }
}

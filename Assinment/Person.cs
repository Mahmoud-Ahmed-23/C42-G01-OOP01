using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Person
    {



        #region Attributes

        private int id;
        private string? name;
        private decimal salary;

        #endregion


        #region Properties

        #region Full Property
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        #endregion


        #region Automatic Property

        public int ID { get; set; }

        public string NAME { get; set; }

        public decimal SALARY { get; set; }


        #endregion

        #endregion


        #region Constructor

        public Person()
        {

        }
        public Person(int id, string name, decimal salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            return $"Id: {id}\nName: {name}\nSalary: {salary:c}";
        }

        #endregion


    }
}

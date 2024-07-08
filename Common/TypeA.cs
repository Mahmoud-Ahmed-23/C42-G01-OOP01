using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// What you can write inside the namespace -->
    /// 
    /// 1.Calss
    /// 2.Struct
    /// 3.Interface
    /// 4.Enum
    /// 


    ///Allowed access modifires inside the namespace -->
    ///
    /// Internal
    /// Public
    ///


    ///Default access modifire inside the namespace --> "Internal"
    ///

    public class TypeA
    {
        ///What you can write inside the [class,struct]
        ///
        /// 1.Attributes [Fields] --> Member Variables
        /// 2.Properties [Full Property, Automatic Property, Indexer]
        /// 3.Functions  [Constructor, Getter Setter, Methods]
        /// 4.Events
        /// 
        ///


        /// Allowed access modifires inside the struct -->
        /// 
        /// 1.Private
        /// 2.Internal
        /// 3.Public
        /// 


        /// Allowed access modifires inside the class -->
        /// 
        /// 1.Private
        /// 2.Private Protected
        /// 3.Protected
        /// 4.Protected Internal
        /// 5.Internal
        /// 6.Public
        /// 
        ///


        /// Default access modifire inside the [struct,class] --> "Private"
        /// 


        /*private*/
        int x;
        internal int y;
        public int z;

    }
    public interface ICar
    {
        /// What you can write inside the Interface
        /// 
        /// 1. Siganture for Method
        /// 2. Siganture for Property
        /// 3. Default Implmented Method
        /// 

        /// Default access modifire inside the interface --> "Public"
        /// 
        void Accelrate();
    }

    public class BMW : ICar
    {
        public void Accelrate()
        {
            Console.WriteLine("400 K/m per h");
        }
    }

    public enum Gender
    {
        male,
        female
    }


    public class Employee
    {
        private protected int Id;
        private protected string? Name;
    }

    public class FullTimeEmployee : Employee
    {
        //private int Id;
        //private string? Name;
        private decimal Salary;
    }


    public class PartTimeEmployee : Employee
    {
        //private int Id;
        //private string? Name;
        private decimal HourRate;
    }

}

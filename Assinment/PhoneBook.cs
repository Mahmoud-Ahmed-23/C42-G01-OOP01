using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class PhoneBook
    {


        #region Attributes

        string[] names;

        long[] numbers;

        int size;

        #endregion


        #region Constructor

        public PhoneBook(int Size)
        {
            this.size = Size;

            names = new string[Size];

            numbers = new long[Size];

        }

        #endregion


        #region Properties

        public int Size
        {
            get
            {
                return size;
            }
        }

        #endregion


        #region Methods
        public void AddPerson(int Postion, string Name, long Number)
        {
            if (names is not null && numbers is not null)
            {
                if (Postion < size && Postion >= 0)
                {
                    names[Postion] = Name;
                    numbers[Postion] = Number;
                }
            }
        }

        public long this[string Name]
        {
            get
            {
                if (numbers is not null && names is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                            return numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                if (numbers is not null && names is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                        {
                            numbers[i] = value;
                            return;
                        }
                    }
                }
            }
        }

        public string this[long index]
        {
            get
            {
                return $"Postion: {index}, Name: {names[index]}";
            }
        }

        #endregion


    }
}

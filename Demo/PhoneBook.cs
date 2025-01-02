using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demo
{
    internal struct PhoneBook
    {
        #region field
        private string[] names;
        private ulong[] numbers;
        private int size;
        #endregion

        #region constractor
        public PhoneBook(int size)
        {
            this.size = size;
            this.names = new string[size];
            this.numbers = new ulong[size];
        }
        #endregion


        #region method


        public void AddPerson(uint position, ulong number, string name)
        {
            if (names is not null && numbers is not null &&position<size)
            {
                names[position] = name;
                numbers[position] = number;
            }
        }

        public long getnum(string name)
        {

            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i]) { }
                    return (long)numbers[i];
                }
            }
            return -1;
        }

        public void setnum(string name, ulong value)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        numbers[i] = value;
                    }
                }
            }
        }
        #endregion
        #region property

        public int Size
        { get { return size; } }


         //indexer  => is special property named  always with [this] and can take paramter
         public long this [string name]
        {
            get
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < size; i++)
                    {
                        if (name == names[i]) { }
                        return (long)numbers[i];
                    }
                }
                return -1;
            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i <size; i++)
                    {
                        if (name == names[i])
                        {
                            numbers[i] = (ulong)value;
                            return;
                        }
                    }
                }
            }
        }

        public string this[int index]
        {
            get { return $"position ={index} , name = {names[index]} , number ={numbers[index]}"; }
        }
        #endregion

    }
}

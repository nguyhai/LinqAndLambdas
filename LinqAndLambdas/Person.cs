using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdas
{
    public class Person
    {
        private string _name;
        private int _height;
        private int _weight;

        private Gender _gender;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public Gender Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public Person(string name, int height, int weight, Gender gender)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Gender = gender;
        }


    }
}

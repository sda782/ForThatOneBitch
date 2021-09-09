using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUp
{
    public abstract class Person : IPerson
    {
        public string _Name;
        public string _Address { get; set; }
        public enum GenderType { Male, Female }
        public GenderType _Gender { get; set; }

        /// <summary>
        /// The first name of a person, must be over 1 character
        /// </summary>
        public string Name
        {
            get => _Name;
            set { if (value.Length < 2) throw new ArgumentOutOfRangeException();
                _Name = value;
            }
        }
        /// <summary>
        /// Address of the person object, must not be null
        /// </summary>
        public string Address
        {
            get => _Address;
            set
            {
                if (value == null) throw new ArgumentNullException();
                _Address = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {_Name}, Address: {_Address}, Gender: {_Gender}";
        }

        public override bool Equals(object obj)
        {
            Person p = obj as Person;

            return _Name.Equals(p.Name) && _Address.Equals(p.Address) && _Gender.Equals(p._Gender);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}

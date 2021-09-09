using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUp
{
    public class Student : Person
    {
        public int _Semester;

        /// <summary>
        /// Student semester, must be between 1 and 8
        /// </summary>
        public int Semester
        {
            get => _Semester;
            set
            {
                if (value < 1 || value > 8) throw new ArgumentOutOfRangeException();
                _Semester = value;
            }
        }

        public Student(string name, string address, int semester, GenderType gender)
        {
            _Name = name;
            _Address = address;
            _Semester = semester;
            _Gender = gender;
        }

        public Student()
        {

        }
    }
}

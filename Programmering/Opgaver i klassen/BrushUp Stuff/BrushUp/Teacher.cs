using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrushUp
{
    public class Teacher : Person
    {
        public int _Salary;


        /// <summary>
        /// Salary of the teacher object, must be above 0
        /// </summary>
        public int Salary
        {
            get => _Salary;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _Salary = value;
            }
        }
    }
}

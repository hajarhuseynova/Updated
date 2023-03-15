using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14Mart.Core.Models.Base;

namespace Task14Mart.Core.Models
{
    public class Teacher:Person
    {
        public readonly int Id;
        public static int countTeacher;

        public Teacher()
        {
            countTeacher++;
            Id = countTeacher;

        }
        public override string ToString()
        {
            return ($"Name:{Name}; Surname:{Surname};Id:{Id};GroupNo:{GroupNo}");
        }

    }
}

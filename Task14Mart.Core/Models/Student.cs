using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14Mart.Core.Models.Base;

namespace Task14Mart.Core.Models
{
    public class Student : Person
    {
        public static int countStudent = 0;
        public readonly int Id;
        public Student()
        {
            countStudent++;
            Id = countStudent;
        }

        public override string ToString()
        {
            return ($"Name:{Name}; Surname:{Surname};Id:{Id};GroupNo:{GroupNo}");
        }


    }
 }

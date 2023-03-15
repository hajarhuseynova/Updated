using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14Mart.Interfaces;
using Task14Mart.Core.Models;
using Task14Mart.Core.Models.Base;


namespace Task14Mart.Extensions
{
    internal static class Check
    {
        public static bool CheckAll(this string correct)
        {
            if(correct == null)
            {
                return false;
            }
            if(correct.Length < 3 || correct.Length > 30)
            {
                return false;
            }
            return true;
           
        }
    }
}

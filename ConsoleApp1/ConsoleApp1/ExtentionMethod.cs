using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class ExtentionMethod
    {
        /// <summary>
        /// Using the standard .NET framework string.IsNullOrEmpty
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        public static bool IsNullOrEmpty(this string inputString)
        {
            if (inputString != null)
            {
                return (inputString.Length == 0);
            }
            return true;

            //Using standard string .NET framework method
            //return String.IsNullOrEmpty(inputString);
        }
    }
}

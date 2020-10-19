using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixTheBug
{
    class Program
    {
        public static double Average(int a ,int b)
        {

            #region WrongImplementation
            //  return a + b / 2;

            //1- division has priority over addition
            //2- int type will trim the fraction
            #endregion





            //fix 
            return (a + b) / 2d;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Average(2, 1));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TylerIsWrongAboutCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Number | Expected  | Actual");
            Console.WriteLine("-------------------------------");

            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "2",  "True",  $"{IsEven(2)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "21", "False", $"{IsEven(21)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "224", "True", $"{IsEven(224)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "1221", "False", $"{IsEven(1221)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "1111", "False", $"{IsEven(1111)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "1020", "True", $"{IsEven(1020)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "11", "False", $"{IsEven(11)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "69690", "True", $"{IsEven(69690)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "121", "False", $"{IsEven(121)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "21257", "False", $"{IsEven(21257)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "20000", "True", $"{IsEven(20000)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "-20", "True", $"{IsEven(-20)}"));
            Console.WriteLine(string.Format("{0,-6} | {1,-10} | {2,5}", "-21", "False", $"{IsEven(-21)}"));

            //Tyler ur wrong

            Console.ReadKey();
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}

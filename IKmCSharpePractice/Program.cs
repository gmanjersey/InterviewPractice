using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKmCSharpePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string mystring = "avavavava";
           // Boxing.TestObjectArrayStringArrayInt();
           // Boxing.DoubleDivisionRoundingTypes();
            //Boxing.StringEqualsVsReferenceEquals();
           // Boxing.IquatableTInt();
           //Boxing.EqaulEqualOperator();
           // Boxing.StringEquality();
           // Boxing.StringObjectEquality();

            //int? a = null;
            //int b = (int) a;
            int a = 1, b = 2;
            if(++a ==1)
                Console.WriteLine(a++ + b * 2);
            else
            {
                Console.WriteLine(a-- * b);
            }

           // string s = string.Format("{1} aaa", "a", "a");

            //object[] array = new string[10];
            //array[0] = 10;

           // string s1 = @"\\My Test \\\\";
           // int i = s1.LastIndexOf(@"\\");

           // bool? a1 = null;
           // bool? b1 = null;
           // var c1 = (a1 & b1);
            //var d1 = (a1 | b1);
        }
    }
}



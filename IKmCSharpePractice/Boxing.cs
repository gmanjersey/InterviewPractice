using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKmCSharpePractice
{
   public class Boxing
    {
        /// <summary>
        /// == operator often gives the same results s object.Equals()
        /// - main exception: nON-PRIMITIVE VALUE-TYPES
        /// If you override object.Equals(), then you should overload ==, to keep them consistent
        /// - note thius hasn't been done for the Tuple, which is confusing
        /// == is not virtual- can give different results from the method when inheritance is involved
        /// == dosen't work well with generics - you may need to use object.Equals
        /// </summary>
        public static void TestObjectArrayStringArrayInt()
        {
            object[] obj = new string[4];
            obj[0] = 10;
        }



        public static void DoubleDivisionRoundingTypes()
        {

            double d = 10 / 4;
            int i = 10 / 4;
            var result = d + i;

            Console.WriteLine("result:" + result + " Type: " + result.GetType());
        }



        public static void StrinBuilderByRefNull(StringBuilder strparam)
        {
            StringBuilder b = new StringBuilder(strparam.ToString());
            strparam = null;
        }

        public static void StringEqualsVsReferenceEquals()
        {
            string banana = "banana";
            string banana2 = string.Copy(banana);

            Console.WriteLine(banana);
            Console.WriteLine((banana2));
            Console.WriteLine(ReferenceEquals(banana,banana2));
            Console.WriteLine(banana.Equals((object) banana2));
        }

        public static void IquatableTInt()
        {
            //IEquatable<T> avoids boxing and gives types safety           
            //IEquatable<T> does not play well with reference types due to inheritance
            //IEquatable<T> is implemented by string but since string is  selaed you cant inherit from it 
            //If you implement IEquatable<T> then you should override object.Equals() too.
            //IEquatable < T > is implemented for int but Microsoft has not done it for ther value types in the Framework c lass library

            //Note that strings Delegates and tuples override object.Equals to provide value equality even though they are reference types.
            //object providses a static Equals methods to deal with null comparisons
            //object provides a static ReferenceEquals to deals with reference Equality (static methods cannot be overriden)

            int three = 3;
            int threeAgain = 3;
            int four = 4;

            Console.WriteLine(three.Equals(threeAgain));
            Console.WriteLine(three.Equals(four));
        }

        public static void EqaulEqualOperator()
        {
            //The == operator does not work well with inheritance and Generics
            //If you overloads the method you should overload the == operator too

            Console.WriteLine("Operator result : " + AreIntsEqualOp(3, 3));
            Console.WriteLine("Method result : " + AreIntsEqualMethod(3, 3));


        }

        public static void StringEquality()
        {
            string str1 = "apple";
            string str2 = string.Copy(str1);

            Console.WriteLine("Reference: " + ReferenceEquals(str1, str2));
            Console.WriteLine("Method: " + str1.Equals(str2));
            Console.WriteLine("Operator : " + (str1 == str2));
            Console.WriteLine("Static : " + object.Equals(str1, str2));
        }


        public static void StringObjectEquality()
        {
            object str1 = "apple";
            object str2 = string.Copy((string) str1);

            Console.WriteLine("Reference: " + ReferenceEquals(str1, str2));
            Console.WriteLine("Method: " + str1.Equals(str2));
            Console.WriteLine("Operator : " + (str1 == str2));
            Console.WriteLine("Static : " + object.Equals(str1,str2));
        }


        static bool AreIntsEqualOp(int x, int y)
        {
            return x == y;
        }

        static bool AreIntsEqualMethod(int x, int y)
        {
            return x.Equals(y);
        }


        public static void DisplayWhetherArgsEqualOp<T>(T x, T y)
            where T: class
        {
            //Console.WriteLine("Equals? " + (x==y));  //will fail since T can be anything -
            //- to resolve this error w have to constraint the method so T has to be a reference type : class
            Console.WriteLine("Equals? " + (x == y));
        }

        public static void DisplayWhetherArgsEqualMethod<T>(T x, T y)
        {
            Console.WriteLine("Equals? " + object.Equals(x,y));
        }

      


    }
}

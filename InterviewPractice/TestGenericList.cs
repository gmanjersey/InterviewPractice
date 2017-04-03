using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Tests
{
   internal class TestGenericList
    {
        private class ExampleClass { }
        static void Main()
        {
            /*
            // Declare a list of type string.
            GenericList<string> list2 = new GenericList<string>();

            // Declare a list of type ExampleClass.
            GenericList<ExampleClass> list3 = new GenericList<ExampleClass>();


            // Declare a list of type int.
            GenericList<int> list1 = new GenericList<int>();

            for (int x = 0; x < 10; x++)
            {
                list1.AddHead(x);
            }

            foreach (int i in list1)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine("\nDone");
            */
        }


    }

    // Declare the generic class.
    // type parameter T in angle brackets
    //Multiple constraints:
    //public class GenericList<T> where T : Employee, IEmployee, System.Icomparable<T>, new()
    public class GenericList<T> where T : Employee
    {
        // The nested class is also generic on T.
        private class Node
        {
            private Node next;

            // T as private member data type.
            private T data;

           // T used in non-generic constructor.
            public Node(T t)
            {
                next = null;
                data = t;
            }
            
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }


            // T as return type of property.
            public T Data
            {
                get { return data; }
                set { data = value; }
            }
        }


        private Node head;

        // constructor
        public GenericList()
        {
            head = null;
        }

        // T as method parameter type:
        public void AddHead(T t)
        {
            Node n = new Node(t);
            n.Next = head;
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public T FindFirstOccurrence(string s)
        {
            Node current = head;
            T t = null;

            while (current != null)
            {
                //The constraint enables access to the Name property.
                if (current.Data.Name == s)
                {
                    t = current.Data;
                    break;
                }
                else
                {
                    current = current.Next;
                }
            }
            return t;
        }
    }

     public class Employee
    {
        private string name;
        private int id;

        public Employee(string s, int i)
        {
            name = s;
            id = i;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
    }
}

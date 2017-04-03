using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Tests.Classes_Partials
{
    public partial class MyPartialClass
    {
        partial void NoImplemented();

        public void Implemented()
        {
            Console.WriteLine("Executing Implemented Starts about to call NotImplemented.");
            NoImplemented();
            Console.WriteLine("Executing Implemented Finish.");
        }
    }
    
}

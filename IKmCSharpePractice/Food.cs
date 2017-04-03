using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKmCSharpePractice
{
    public class Food
    {
        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }

        public Food(string name, FoodGroup group)
        {

            this._name = name;
            this._group = group;
        }


        public override string ToString()
        {
            return _name;
        }


    }
}

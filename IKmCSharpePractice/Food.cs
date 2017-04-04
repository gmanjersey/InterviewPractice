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

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
        
            Food rhs = obj as Food;
            return this._name == rhs.Name && this._group == rhs.Group;
        }

        public override int GetHashCode()
        {
            return this._name.GetHashCode() ^ this._group.GetHashCode();
        }

        public static bool operator ==(Food x, Food y)
        {
            //return x._name == y._name && x._group == y._group; //this will NOT work properly since inheritance wont work on static methods.
            return object.Equals(x, y);
        }

        public static bool operator !=(Food x, Food y)
        {
            return !object.Equals(x, y);
        }
    }
}

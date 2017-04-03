using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKmCSharpePractice
{

    public enum FoodGroup { Meat, Fruit, Vegetables, Sweets}

    public struct  FoodItem : IEquatable<FoodItem>
    {

        private readonly string _name;
        private readonly FoodGroup _group;

        public string Name { get { return _name; } }
        public FoodGroup Group { get { return _group; } }

        public FoodItem(string name, FoodGroup group)
        {

            this._name = name;
            this._group = group;
        }


        public override string ToString()
        {
            return _name;
        }

        public bool Equals(FoodItem other)
        {
            return this._name == other.Name && this._group == other.Group;
        }

        public override bool Equals(object obj)
        {
            if (obj is FoodItem)
                return Equals((FoodItem) obj);
            else
            {
                return false;
            }
        }

        public static bool operator ==(FoodItem lhs, FoodItem rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(FoodItem lhs, FoodItem rhs)
        {
            return !(lhs == rhs);
        }
        ///HasCoder rules if x.Equals(y) then x.GetHashCode() == y.GetHashCode()
        /// Dictionry<Tkey, TValue> uses a underlying HashTable - if you override equality for a type you must override GetHasCode for the type
        /// 
        public override int GetHashCode()
        {
            return _name.GetHashCode() ^ _group.GetHashCode();//^  is the exclusive OR operator
        }


        public static void TestFoodItemEqualityOpOverload()
        {
            FoodItem banana = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem banana2 = new FoodItem("banana", FoodGroup.Fruit);
            FoodItem chocolate = new FoodItem("chocolate", FoodGroup.Sweets);

            Console.WriteLine("banana == banana2   :       " + (banana == banana2));
            Console.WriteLine("banana2 == chocolate:       " + (banana2 == chocolate));
            Console.WriteLine("chocolate == banana :       " + (chocolate == banana));
        }

    }
}

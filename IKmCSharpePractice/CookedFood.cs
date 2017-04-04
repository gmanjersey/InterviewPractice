using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKmCSharpePractice
{
    public sealed class CookedFood : Food
    {
        private readonly string _cookingMethod;

        public string CookingMthod { get { return _cookingMethod; } }

        public CookedFood(string cookingMethod, string name, FoodGroup @group) : base(name, @group)
        {
            this._cookingMethod = cookingMethod;
        }

        public static bool operator ==(CookedFood x, CookedFood y)
        {
            return object.Equals(x, y);
        }


        public static bool operator !=(CookedFood x, CookedFood y)
        {
            return !object.Equals(x, y);
        }
        
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this._cookingMethod.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!base.Equals(obj))
                return false;
            CookedFood rhs = (CookedFood) obj;
            return this._cookingMethod == rhs._cookingMethod;
        }

        public override string ToString()
        {
            return  string.Format("{0} {1}" ,_cookingMethod, Name);
        }

        public static void FoodEqualityTest()
        {
            Food apple = new Food("apple", FoodGroup.Fruit);
            CookedFood stewedApple = new CookedFood("stewed", "apple", FoodGroup.Fruit);
            Console.WriteLine(apple);
            Console.WriteLine(stewedApple);

            CookedFood bakedApple = new CookedFood("baked", "apple", FoodGroup.Fruit);
            CookedFood stewedApple2 = new CookedFood("stewed", "apple", FoodGroup.Fruit);

            Food apple2 = new Food("apple", FoodGroup.Fruit);

            DisplayWhetherEqual(apple, stewedApple);
            DisplayWhetherEqual(stewedApple, bakedApple);
            DisplayWhetherEqual(stewedApple, stewedApple2);
            DisplayWhetherEqual(apple, apple2);
        }

        private static void DisplayWhetherEqual(Food food1, Food food2)
        {
            if(food1 == food2)
                Console.WriteLine(string.Format("{0,12} == {1}", food1, food2));
            else
            {
                Console.WriteLine(string.Format("{0,12} != {1}", food1, food2));
            }
        }


        private static void DisplayWhetherEqual(object food1, object food2)
        {
            if (food1 == food2)
                Console.WriteLine(string.Format("{0,12} == {1}", food1, food2));
            else
            {
                Console.WriteLine(string.Format("{0,12} != {1}", food1, food2));
            }
        }
    }
}

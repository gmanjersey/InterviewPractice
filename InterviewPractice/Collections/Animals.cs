using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Tests.Collections
{
    public class Animals : CollectionBase
    {
        public void Add(Animal newAnimal)
        {
            List.Add(newAnimal);
        }

        public void Remove(Animals oldAnimal)
        {
            List.Remove(oldAnimal);
        }

        public Animals() { }


        //note we can do animalCollection[0].Feed(); //unless we define an indexer.
        //Indexer below:
        public Animal this[int animalIndex]
        {
            get { return (Animal) List[animalIndex]; }
            set { List[animalIndex] = value; }
        }

        /// <summary>
        /// This implementation assumes that traget and source are the same size.
        /// </summary>
        /// <param name="target"></param>
        public void CopyTo(Animals target)
        {
            for (int index = 0; index < this.Count; index++)
            {
                target[index] = this[index];
            }
        }
         
        public bool Contains(Animal animal) => InnerList.Contains(animal);
    }
}

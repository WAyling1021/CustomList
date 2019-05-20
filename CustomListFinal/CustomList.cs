using System;
namespace Application
{
    class CustomList<T>
    {

        //member variables 
        //array holds all items in the list
        public T[] items = new T[];


        //constructor 
        //tells us how many items in the list
        public int Count { get { return count; } }
        private int count;

        //member methods 
        //adds item to list (really the items array)
        public void Add(T item)
        {
            T[] temp = new T[capacity * 2];

            //copy values over (for loop) 
            items[count] = item;
            count++;

            for (int i = 0; i = < 3; i++)
                if (i == 3)
                {
                    continue;
                }

            Console.WriteLine(i);
        }
    }
}

using System;
namespace CustomListFinal
{
    class CustomList<T>
    {

        //member variables 
        //array holds all items in the list
        public T[] items = new T[4];


        //constructor 
        //tells us how many items in the list
        public int Count { get { return count; } }
        private int count;

        //member methods 
        //adds item to list (really the items array)
        public void Add(T item)
        {
             public int Capacity { get; set; }


        //copy values over (for loop) 

         

        T[] temp = new T[capacity * 2];
            for (int i = 0; i < count; i++)
         {
           

         }

            items[count] = item;
            count++;
         }
    }
}

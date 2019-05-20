using System;

namespace CustomListFinal
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CustomList<int> myList = new CustomList<int>();
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(13);
            myList.Add(23);
        }
    }
}

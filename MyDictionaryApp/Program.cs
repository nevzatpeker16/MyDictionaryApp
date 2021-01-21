using System;

namespace MyDictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            MyDictionary<int ,string > deneme = new MyDictionary<int,string>();
            deneme.AddItem(1, "Nevzat");
            deneme.AddItem(2, "Bilge");
           

            foreach(var key in deneme.ListKeys)
            {
                Console.WriteLine(key);
            }
            foreach(var Values in deneme.ListValues)
            {
                Console.WriteLine(Values);
            }
        }
    }
}

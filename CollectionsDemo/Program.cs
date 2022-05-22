using System.Collections.Generic;

namespace CollectionsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            Console.WriteLine("\t\t\t\t\tWELCOME TO COLLECTIONS DEMO PROGRAM\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t-----------------------------------\t\t\t\t\t");
            collection.ListDemo();
            collection.SetDemo();
            collection.QueueDemo();
            collection.SetDemo();
            collection.DictionaryDemo();
        }
    }
}
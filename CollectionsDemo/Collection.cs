using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Collection
    {
        public void ListDemo()
        {
            List<string> list = new List<string>();
            list.Add("Sneha");
            list.Add("Vidya");
            list.Add("Shree");
            list.Add("Neha");
            list.Add("Siri");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(" ");
        }
        public void StackDemo()
        {
            Stack<string> list = new Stack<string>();
            list.Push("Sneha");
            list.Push("Vidya");
            list.Push("Shree");
            list.Push("Neha");
            list.Push("Siri");
            string pop = list.Pop();
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("\nPopped Elements : " + pop);
        }
        public void QueueDemo()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Sneha");
            queue.Enqueue("Sneha");
            queue.Enqueue("Shree");
            queue.Enqueue("Neha");
            queue.Enqueue("Siri");
            string deleteQue = queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item + " ");
            }
            Console.Write("\nDeleted  Elements : \t" + deleteQue);
        }
        public void SetDemo()
        {
            var set = new HashSet<string>();
            set.Add("Sneha");
            set.Add("Radha");
            set.Add("Vidya");
            set.Add("Shree");
            set.Add("Neha");

            HashSet<string>.Enumerator enumerator = set.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }
        public void DictionaryDemo()
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(101, "Sneha");
            keyValuePairs.Add(102, "Sneha");
            keyValuePairs.Add(103, "Vidya");
            keyValuePairs.Add(104, "Shree");
            keyValuePairs.Add(105, "Neha");
            keyValuePairs.Add(106, "Siri");
            Console.WriteLine("\n");
            foreach (var pair in keyValuePairs)
            {
                Console.WriteLine("Key : " + pair.Key + "\t" + "Values : " + pair.Value);
            }
        }
    }
}

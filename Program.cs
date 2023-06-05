using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Gyakorlas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region ArrayList 
			Console.WriteLine("Array list example:");

			ArrayList aList = new ArrayList();
			aList.Add("Bob");
			aList.Add("Bill");

			Console.WriteLine("Count : {0}", aList.Count);
			Console.WriteLine("Capacity : {0}", aList.Capacity);

			ArrayList aList2 = new ArrayList();
			aList2.AddRange(new object[] { "Mike", "Sally", "Egg" });

			aList.AddRange(aList2);

			aList2.Sort();
			aList2.Reverse();

			aList.Insert(1, "Turkey");

			//aList2.RemoveAt(0);
			//aList2.RemoveRange(0, 2);

			Console.WriteLine("Turkey Index : {0}", aList2.IndexOf("Turkey", 0));

			foreach (object o in aList)
			{
				Console.WriteLine(o);
			}

			string[] myArray = (string[])aList.ToArray(typeof(string));
			string[] customers = { "Bob", "Sally", "Sue" };
			ArrayList customerArrayList = new ArrayList();
			customerArrayList.AddRange(customers);
			Console.WriteLine();

			#endregion

			#region Dictionary
			Console.WriteLine("Dictionary example:");
			Dictionary<string, string> superheroes = new Dictionary<string, string>();

			superheroes.Add("Clark Kent", "Superman");
			superheroes.Add("Bruce Wayne", "Batman");
			superheroes.Add("Berry Allen", "The Flash");

			superheroes.Remove("Berry Allen");

			Console.WriteLine($"Count : {superheroes.Count}");

			Console.WriteLine($"Clark Kent : {superheroes.ContainsKey("Clark Kent")}");

			superheroes.TryGetValue("Clark Kent", out string test);
			Console.WriteLine($"Clark Kent : {test}");

			foreach (KeyValuePair<string, string> item in superheroes)
			{
				Console.WriteLine("{0} : {1}", item.Key, item.Value);
			}
            
			
			Console.WriteLine();
			#endregion

			#region Queue (FIFO)
			Console.WriteLine("Queue example:");

			Queue queue = new Queue();
			queue.Enqueue(1);
			queue.Enqueue(2);
			queue.Enqueue(3);

            Console.WriteLine("1 in Queue : {0}", queue.Contains(1));
			Console.WriteLine("Remove : {0}", queue.Dequeue());
			Console.WriteLine("Peek 1 : {0}", queue.Peek());

			object[] numArray = queue.ToArray();
            Console.WriteLine(String.Join(",", numArray));
			foreach (object o in queue) 
			{
                Console.WriteLine($"Queue : {o}");
            }

			queue.Clear();

            Console.WriteLine();
			#endregion

			#region Stack (LIFO)
			Console.WriteLine("Stack example:");

			Stack stack = new Stack();
			stack.Push(1);
			stack.Push(2);
			stack.Push(3);

            Console.WriteLine("Peek 1 : {0}", stack.Peek());
			Console.WriteLine("Pop 1 : {0}", stack.Pop());
			Console.WriteLine("Contain 1 : {0}", stack.Contains(1));

			object[] numArray2 = stack.ToArray();
            Console.WriteLine(String.Join(",", numArray2));

			foreach (object o in stack)
			{
				Console.WriteLine($"Stack : {o}");
			}

            #endregion

            Console.ReadKey();
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue <Person> people = new Queue <Person> ();
            string line, file = "text.txt"; int k;
            using (StreamReader MyFile = new StreamReader(file))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    string [] data = line.Split(' ');
                    if (data.Length == 5)
                    {
                        Person NewPerson = new Person(data[0], data[1], data[2], int.Parse(data[3]), float.Parse(data[4]));
                        people.Enqueue(NewPerson);
                    }
                }
            }
            k = people.Count;
            Console.WriteLine("---------People younger than 40:---------");
            for (int i = 0; i < k; i++) {
                if (people.Peek().Vik < 40)
                {
                    Console.WriteLine(people.Dequeue());
                }
                else
                    people.Enqueue(people.Dequeue());
            }
            Console.WriteLine("\n---------People older than 40:---------");
            while(people.Count!=0)
            {
                if (people.Peek().Vik >= 40)
                {
                    Console.WriteLine(people.Dequeue());
                }
            }
            Console.ReadKey();
        }
    }
}

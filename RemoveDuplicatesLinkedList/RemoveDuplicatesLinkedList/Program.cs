using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // create linked List
            var names = new LinkedList<string>();
            names.AddFirst("Anakin");
            names.AddLast("Luke");

            AddToLinkedListAfter(names, "Padme", "Anakin");
            AddToLinkedListAfter(names, "JabbaTheHut", "Padme");
            AddToLinkedListAfter(names, "Luke", "JabbaTheHut");
            AddToLinkedListAfter(names, "HansSolo", "Luke");

            // display original list with duplicates
            Console.Write("Original list: ");
            PrintLinkedList(names);

            // check for duplicates and remove
            var keep_removing = true;
            while (keep_removing)
            {
                keep_removing = false;
                var name_to_remove = "";
                var list = "";
                foreach (string name in names)
                {
                    if (list.Contains(name))
                    {
                        name_to_remove = name;
                        keep_removing = true;
                        break;  // must go outside foreach in order to remove
                    }
                    list = list + name + ",";
                }
                if (name_to_remove != "")
                {
                    Console.WriteLine("<" + name_to_remove + ">" + " appears several times!");
                    RemoveFromLinkedList(names, name_to_remove);
                }
            }

            // display again list with removed duplicates
            Console.Write("New list: ");
            PrintLinkedList(names);

            Console.ReadLine();
        }

        public static void AddToLinkedListAfter(LinkedList<string> lista, string newElement, string afterElement)
        {
            var pos = lista.Find(afterElement);
            lista.AddAfter(pos, newElement);
        }

        public static void RemoveFromLinkedList(LinkedList<string> lista, string element)
        {
            var pos = lista.Find(element);
            lista.Remove(element);
        }

        public static void PrintLinkedList(LinkedList<string> lista)
        {
            foreach (string element in lista)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine("");
        }
    }
}

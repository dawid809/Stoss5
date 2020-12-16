using System;

namespace Stoss
{
    class Program
    {
        static void Main(string[] args)
        {
            StosWTablicy<string> s = new StosWTablicy<string>(10);
            s.Push("km");
            s.Push("aa");
            s.Push("xx");
            s.Push("zz");
            s.Push("gg");

            
            foreach (var x in s.ToArray())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine($"\nBefore TrimExcess : {s.TabLenght()}");
            s.TrimExcess();
            Console.WriteLine($"After TrimExcess : {s.TabLenght()}\n");

            Console.Write("Indexer : ");

            for (int i = 0; i < s.Count; i++)
            {
                Console.Write($"[{i}]{s[i]} ");
            }

            Console.WriteLine("\n\nIterator \"od zera\"");

            foreach (var x in s)
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nIterator TopToBottom");

            foreach (var x in s.TopToBottom)
            {
                Console.WriteLine(x);
            }

            var ToArray = s.ToArray();
            var ToArrayReadOnly = s.ToArrayReadOnly();
            ToArray[3] = "abc";
            //ToArrayReadOnly[3] = "abc"; błąd - tylko do odczytu
           
        }
    }
}

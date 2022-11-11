using System;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _words = { "home", "programming", "C#", "Football", "work", "travel" };
            string _letter = Console.ReadLine();
            int _count = 0;

            foreach (var item in _words)
            {
                if (item.Contains(_letter)) Console.WriteLine(item);
                else _count += 1;
            }

            if (_count > (_words.Length - 1)) Console.Write("No match");
        }
    }
}

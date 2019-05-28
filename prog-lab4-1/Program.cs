using System;
using System.IO;

namespace prog_lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader MyFile = new StreamReader("microsoft.txt");
            string Text = MyFile.ReadToEnd();
            Console.WriteLine("all text is:\n" + Text); 
            string[] words = Text.Split(new Char[] { ' ', ',', '.', '(', ')' });
            char LastLetter = words[0][ (words[0].Length-1) ];
            int Count = 0;

            foreach (string a in words)
            {
            if (a.Length!=0 && a[a.Length - 1] == LastLetter)
                {
                    Console.WriteLine(a);
                    Count++;
                }
            }
            Console.WriteLine("result is " + Count + " words");
        }
    }
}
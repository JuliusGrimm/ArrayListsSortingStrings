using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListsSortingStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> al = new List<string>();
            string sResp = string.Empty;

            do
            {
                Console.Clear();
                Console.Write("Enter File Name to Sort: ");
                string filename = Console.ReadLine();

                DirectoryInfo di = new DirectoryInfo(".");
                if (File.Exists(di.FullName + "\\" + filename))
                {
                   
                    ReadTheFile(al, filename);
                    Print(al);
                    Console.WriteLine();
                    Sort(al);
                    Print(al);
                    Pause();
                }
                else
                {
                    Console.WriteLine("File not found.");
                    
                }
                Console.WriteLine("Search again? Y/N");
                sResp = Console.ReadLine().ToUpper();
            } while (sResp == "Y");
           
          
        }
        static void Sort(List<string> a)
        {
            bool swapped = false;
            do
            {
                swapped = false;
                for (int i = 0; i < a.Count - 1; i++)
                {
                    int j = String.Compare(a[i].ToString(),
                        a[i + 1].ToString());

                    if (j > 0)
                    {
                        string temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped == true);
        }

        static void Print(List<string> a)
        {
            for (int i = 0; i < a.Count; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static void Pause()
        {
            Console.WriteLine("\n\tPress any key to continue");
            Console.ReadLine();
        }

        static void ReadTheFile(List<string> a, string filename)
        {
            StreamReader sr = new StreamReader(filename);
            while (sr.Peek() >= 0)
            {
                string line = sr.ReadLine();
                a.Add(line);
            }
        }
    }
}

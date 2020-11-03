using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFile
{
    class Program
    {
        //file path of text files under bin\Debug\names.txt

        public static string filePath = @"names.txt";
        public static string filePath2 = @"address.txt";
        public static object Contacts { get; private set; }

        static void Main(string[] args)
        {
            Readcsv();
            WriteNames();
            WriteAddress();
            Console.ReadLine();
        }

        public static void Readcsv()
        {
            var lines = File.ReadAllLines("Data.csv");

            foreach(var line in lines)
            {
                Console.WriteLine(line);
            }
        }

        //write names to file 
    
        public static void WriteNames()
        {
            List<string> names = File.ReadLines("Data.csv").ToList();

            foreach (var name in names)
            {
                string[] entry = name.Split(',');
                File.WriteAllLines(filePath, names);

                Console.WriteLine("");
            }


        }

        //write address to file 
     
        public static void WriteAddress()
        {
            List<string> lines = File.ReadLines("Data.csv").ToList();

            foreach (var line in lines)
            {
                string[] entry = line.Split(',');

                File.WriteAllLines(filePath2, entry);

                Console.WriteLine("");
            }

        }

    }

    // local csv data class 
    public class Contact
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public bool isFound { get; set; }
    }
}

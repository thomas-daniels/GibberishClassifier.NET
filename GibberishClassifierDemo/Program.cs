using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using GibberishClassification;

namespace GibberishClassifierDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();
                Console.WriteLine(GibberishClassifier.Classify(line.Trim()) + "% chance that this line is gibberish.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sample");

            var lines = File.ReadAllLines("MessageDefinition.csv");

            foreach (var line in lines)
            {
                Console.WriteLine("line:" + line);

                var elements = line.Split(',').ToArray();
                Console.WriteLine("element[0]:" + elements[0]);
                Console.WriteLine("element[1]:" + elements[1]);
                Console.WriteLine("element[2]:" + elements[2]);
                Console.WriteLine("element[3]:" + elements[3]);
            }
        }
    }
}

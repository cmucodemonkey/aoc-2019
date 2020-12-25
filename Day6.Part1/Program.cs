using System;
using System.IO;
using System.Linq;

namespace Day6.Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree();
            string[] lines = File.ReadAllLines("Input.txt");

            foreach (var line in lines)
            {
                string[] splitLine = line.Split(')');

                var firstNode = tree.FindNode(splitLine[0]);

                if (firstNode == null)
                {
                    firstNode = new Node(splitLine[0]);
                    tree.Nodes.Add(firstNode);
                }

                var secondNode = tree.FindNode(splitLine[1]);

                if (secondNode == null)
                {
                    secondNode = new Node(splitLine[1]);
                    tree.Nodes.Add(secondNode);
                }
                
                firstNode.Children.Add(secondNode);
            }

            int count = 0;

            foreach (var node in tree.Nodes)
            {
                var parentNode = tree.Nodes.FirstOrDefault(n => n.Children.Contains(node));

                if (parentNode != null)
                    count++;

                do
                {
                    parentNode = tree.Nodes.FirstOrDefault(n => n.Children.Contains(parentNode));

                    if (parentNode != null)
                        count++;
                } while (parentNode != null);
            }

            Console.WriteLine(count);
            Console.WriteLine("Press any key to continue...");
            Console.Read();
        }
    }
}

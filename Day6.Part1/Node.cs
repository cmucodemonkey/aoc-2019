using System.Collections.Generic;

namespace Day6.Part1
{
    public class Node
    {
        public string ID { get; }
        public List<Node> Children { get; }

        public Node(string id)
        {
            ID = id;
            Children = new List<Node>();
        }
    }
}
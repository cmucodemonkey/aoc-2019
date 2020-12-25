using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Day6.Part1
{
    public class Tree : IEnumerable
    {
        public List<Node> Nodes { get; }

        public Tree()
        {
            Nodes = new List<Node>();
        }

        public IEnumerator GetEnumerator()
        {
            return Nodes.GetEnumerator();
        }

        public Node FindNode(string id)
        {
            return Nodes.FirstOrDefault(n => n.ID == id);
        }
    }
}
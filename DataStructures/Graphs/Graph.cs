using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Graphs
{
    public class Graph<T, TCost> : IGraph<T, TCost>
        where TCost: IComparable
    {
        private readonly List<GraphNode<T, TCost>> nodes
            = new List<GraphNode< T, TCost>>();

        public GraphNode<T, TCost> this[int index]
        {
            get => nodes[index];
        }

        public int Count
        {
            get => nodes.Count;
        }

        private GraphNode<T, TCost> AddIfNeeded(T value)
        {
            if (Find(value) is GraphNode<T, TCost> existingNode)
            {
                return existingNode;
            }

            var node = new GraphNode<T, TCost>(value);
            nodes.Add(node);
            return node;
        }

        public Graph<T, TCost> Add(T from, T to, TCost cost)
        {
            if (from.Equals(to)) throw new InvalidOperationException();

            var fromNode = AddIfNeeded(from);
            var toNode = AddIfNeeded(to);

            fromNode.AddNeighbor(toNode, cost);
            toNode.AddNeighbor(fromNode, cost);
            return this;
        }

        public bool Contains(T value)
            => nodes.Any(x => x.Value.Equals(value));

        private GraphNode<T, TCost> Find(T value)
            => nodes.FirstOrDefault(x => x.Value.Equals(value));

        public IEnumerator<GraphNode<T, TCost>> GetEnumerator() => nodes.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

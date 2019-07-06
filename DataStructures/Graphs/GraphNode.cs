using System;
using System.Collections.Generic;
using System.Linq;

namespace DataStructures.Graphs
{
    public class GraphNode<T, TCost> : Node<T>
        where TCost : IComparable
    {
        public List<Neighbor<T, TCost>> Neighbors { get; private set; }

        public GraphNode(T value) : base(value) {
            Neighbors = new List<Neighbor<T, TCost>>();
        }

        public GraphNode<T, TCost> AddNeighbor(Node<T> neighbor, TCost cost)
        {
            if (!Neighbors.Any(x => x.Node.Value.Equals(neighbor.Value)))
            {
                Neighbors.Add(new Neighbor<T, TCost>(neighbor, cost));
            }

            return this;
        }
    }
}

using System;
using System.Collections.Generic;

namespace DataStructures.Graphs
{
    public interface IGraph<T, TCost> : IEnumerable<GraphNode<T, TCost>>
        where TCost : IComparable
    {
        GraphNode<T, TCost> this[int index] { get; }
        int Count { get; }

        Graph<T, TCost> Add(T from, T to, TCost cost);
        bool Contains(T value);
    }
}

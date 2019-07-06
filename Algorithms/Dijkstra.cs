using System;
using DataStructures.Graphs;

namespace Algorithms
{
    public class Dijkstra<T, TCost> : IRouteFinder<T, TCost>
        where TCost : IComparable
    {
        private readonly IGraph<T, TCost> graph;

        public Dijkstra(IGraph<T, TCost> graph)
        {
            this.graph = graph;
        }

        public bool TryFindRoute(T from, T to, out Route<T, TCost> route)
        {
            throw new NotImplementedException();
        }
    }
}

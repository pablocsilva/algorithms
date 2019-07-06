using System.Collections.Generic;
using DataStructures;

namespace Algorithms
{
    sealed public class Route<T, TCost>
    {
        public List<Node<T>> Nodes => new List<Node<T>>();
        public TCost Cost { get; set; }
    }
}

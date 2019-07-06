namespace DataStructures.Graphs
{
    sealed public class Neighbor<T, TCost>
    {
        public Node<T> Node { get; private set; }
        public TCost Cost { get; set; }

        public Neighbor(Node<T> node, TCost cost)
        {
            Node = node;
            Cost = cost;
        }
    }
}

namespace DataStructures
{
    public abstract class Node<T>
    {
        public T Value { get; set; }
        
        protected Node(T value)
        {
            Value = value;
        }
    }
}

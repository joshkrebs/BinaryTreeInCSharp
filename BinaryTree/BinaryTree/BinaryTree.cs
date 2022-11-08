namespace BinaryTree
{
    public class BinaryTree<T>
    {
        public int Count { get; private set; }

        public Node<T>? Root { get; private set; }

        public void Add(T value)
        {
            // TODO: Add Node Logic
            Count++;
        }
    }
}
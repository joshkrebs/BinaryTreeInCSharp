namespace BinaryTree
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public int Count { get; private set; }

        public Node<T>? Root { get; private set; }

        public void Add(T value)
        {
            // TODO: Add Node Logic
            Node<T> newNode = new Node<T>(value);
            
            if(Root == null)
            {
                Root = newNode;
            }
            else
            {
                Root.AddChild(newNode);
            }

            Count++;
        }
    }
}
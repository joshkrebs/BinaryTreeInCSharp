using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Node<T> where T : IComparable<T>
    {
        public readonly T Value;
        public Node<T>? Left { get; private set; }
        public Node<T>? Right { get; private set; }
        
        public Node(T value)
        {
            Value = value;
        }

        public void AddChild(Node<T> child)
        {
            if (child.Value.CompareTo(Value) < 0)
            {
                if (Left == null) Left = child;
                else Left.AddChild(child);
            }
            else
            {
                if(Right == null) Right = child;
                else Right.AddChild(child);
            }

        }
    }
}

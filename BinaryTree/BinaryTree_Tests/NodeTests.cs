using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree_Tests
{
    using BinaryTree;

    public class NodeTests
    {
        [Fact]
        public void Node_ReturnsCorrectIntValue()
        {
            var testValue = 1;
            var node = new Node<int>(testValue);

            node.Value.Should().Be(testValue);
        }

        [Fact]
        public void Node_ReturnsCorrectStringValue()
        {
            var testValue = "Hello";
            var node = new Node<string>(testValue);

            node.Value.Should().Be(testValue);
        }

        [Fact]
        public void Node_StartsWithNullChildren()
        {
            Node<int> node = new Node<int>(1);

            node.Left.Should().BeNull();
            node.Right.Should().BeNull();
        }

        [Fact]
        public void Node_AddsLeftchild()
        {
            int parentValue = 1;
            int childValue = 0;
            Node<int> parent = new Node<int>(parentValue);
            Node<int> child = new Node<int>(childValue);

            parent.AddChild(child);

            parent.Left.Should().NotBeNull();
            parent.Left?.Value.Should().Be(0);
        }
    }
}

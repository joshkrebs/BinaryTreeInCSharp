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
    }
}

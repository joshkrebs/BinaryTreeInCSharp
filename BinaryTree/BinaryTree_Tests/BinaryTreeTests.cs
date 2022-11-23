using System.ComponentModel.DataAnnotations;

namespace BinaryTree_Tests
{
    public class ComplexTree
    {
        [Fact(DisplayName = "Recursively adds to the left child's left")]
        public void Tree_AddsChild_Left_Left()
        {
            var tree = new BinaryTree<int>();
            tree.Add(10);
            tree.Add(7);
            tree.Add(5);

            tree.Root!.Value.Should().Be(10);
            tree.Root!.Left!.Value.Should().Be(7);
            tree.Root!.Left!.Left!.Value.Should().Be(5);
        }

        [Fact(DisplayName = "Recursively adds to the left child's right")]
        public void Tree_AddsChild_Left_Right()
        {
            var tree = new BinaryTree<int>();
            int first = 10;
            int second = 7;
            int third = 8;
            tree.Add(first);
            tree.Add(second);
            tree.Add(third);

            tree.Root!.Value.Should().Be(first);
            tree.Root!.Left!.Value.Should().Be(second);
            tree.Root!.Left!.Right!.Value.Should().Be(third);
        }

        [Fact(DisplayName = "Recursively adds to the right child's left")]
        public void Tree_AddsChild_Right_Left()
        {
            var tree = new BinaryTree<int>();
            tree.Add(10);
            tree.Add(17);
            tree.Add(15);

            tree.Root!.Value.Should().Be(10);
            tree.Root!.Right!.Value.Should().Be(17);
            tree.Root!.Right!.Left!.Value.Should().Be(15);
        }

        [Fact(DisplayName = "Recursively adds to the right child's right")]
        public void Tree_AddsChild_Right_Right()
        {
            var tree = new BinaryTree<int>();
            tree.Add(10);
            tree.Add(17);
            tree.Add(18);

            tree.Root!.Value.Should().Be(10);
            tree.Root!.Right!.Value.Should().Be(17);
            tree.Root!.Right!.Right!.Value.Should().Be(18);
        }
    }

    public class EmptyTree
    {
        [Fact]
        public void EmptyTree_HasNodeCount_0()
        {
            var tree = new BinaryTree<int>();

            //Standard Assertion
            //Assert.Equal(0, tree.Count);

            //Fluent Assertion
            tree.Count.Should().Be(0);
        }

        [Fact]
        public void EmptyTree_HasNullRoot()
        {
            var tree = new BinaryTree<int>();

            tree.Root.Should().BeNull();
        }
    }

    public class FullTree
    {
        [Fact]
        public void FullTree_RootWithTwoChildren()
        {
            var tree = new BinaryTree<int>();
            tree.Add(10);
            tree.Add(7);
            tree.Add(12);

            tree.Root!.Value.Should().Be(10);
            tree.Root!.Left!.Value.Should().Be(7);
            tree.Root!.Right!.Value.Should().Be(12);
        }

        [Fact]
        public void FullTree_HasNodeCount3()
        {
            var tree = new BinaryTree<int>();
            tree.Add(10);
            tree.Add(7);
            tree.Add(12);

            tree.Count.Should().Be(3);
        }
    }

    public class SimpleTree
    {
        [Fact]
        public void SimpleTree_HasNodeCount_1()
        {
            var tree = new BinaryTree<int>();
            tree.Add(1);

            tree.Count.Should().Be(1);
        }

        [Fact]
        public void SimpleTree_HasRootWithInitialValue()
        {
            var tree = new BinaryTree<int>();
            tree.Add(1);

            tree.Root.Should().NotBeNull();
            tree.Root!.Value.Should().Be(1);
        }

        [Fact]
        public void SimpleTree_AddsChildToTheLeft()
        {
            var tree = new BinaryTree<int>();
            tree.Add(10);
            tree.Add(7);

            tree.Root!.Value.Should().Be(10);
            tree.Root!.Right.Should().BeNull();
            tree.Root!.Left.Should().NotBeNull();
            tree.Root!.Left!.Value.Should().Be(7);
        }

        [Fact]
        public void SimpleTree_AddsChildToTheRight()
        {
            var tree = new BinaryTree<int>();
            tree.Add(10);
            tree.Add(17);

            tree.Root!.Value.Should().Be(10);
            tree.Root!.Left.Should().BeNull();
            tree.Root!.Right.Should().NotBeNull();
            tree.Root!.Right!.Value.Should().Be(17);
        }

        [Fact]
        public void SimpleTree_AddsEqualChildToTheRight()
        {
            var tree = new BinaryTree<int>();
            tree.Add(10);
            tree.Add(10);

            tree.Root!.Value.Should().Be(10);
            tree.Root!.Left.Should().BeNull();
            tree.Root!.Right.Should().NotBeNull();
            tree.Root!.Right!.Value.Should().Be(10);
        }
    }
}
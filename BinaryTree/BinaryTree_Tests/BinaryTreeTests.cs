namespace BinaryTree_Tests
{
    using BinaryTree;

    public class BinaryTreeTests
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
        }


    }
}
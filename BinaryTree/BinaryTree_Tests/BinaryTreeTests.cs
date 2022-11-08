namespace BinaryTree_Tests
{
    using BinaryTree;

    public class BinaryTreeTests
    {
        [Fact]
        public void EmptyTree_HasNodeCount_0()
        {
            var tree = new BinaryTree();

            Assert.Equal(0, tree.Count);
        }
    }
}
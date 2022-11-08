namespace BinaryTree_Tests
{
    using BinaryTree;

    public class BinaryTreeTests
    {
        [Fact]
        public void EmptyTree_HasNodeCount_0()
        {
            var tree = new BinaryTree();

            //Standard Assertion
            //Assert.Equal(0, tree.Count);

            //Fluent Assertion
            tree.Count.Should().Be(0);
        }
    }
}
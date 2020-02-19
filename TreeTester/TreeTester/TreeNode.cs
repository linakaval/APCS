namespace TreeTester
{
    public class TreeNode
    {
        public /* private */ object myValue;
        public /* private */ TreeNode myLeft;
        public /* private */ TreeNode myRight;

        // Constructor:

        public TreeNode(object initValue, TreeNode initLeft, TreeNode initRight)
        {
            myValue = initValue;
            myLeft = initLeft;
            myRight = initRight;
        }

        //public TreeNode LeftChild
        //{
        //    get { return myLeft; }
        //    set { myLeft = value; }
        //}

        //public TreeNode RightChild
        //{
        //    get { return myRight; }
        //    set { myRight = value; }
        //}

        //public object DataValue
        //{
        //    get { return myValue; }
        //    set { myValue = value; }
        //}
    }
}
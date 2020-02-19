using System;

namespace TreeTester
{
    public class TreeADT
    {
        //TODO: Binary Search Tree Implementation goes here.
        private TreeNode myRoot;
        private int myCount;

        public TreeADT()
        {
            myRoot = new TreeNode(null, null, null);
        }

        public void insert(IComparable data)
        {
            insert(data, ref myRoot);
        }

        //public TreeNode delete(IComparable data)
        //{
        //    return delete(data, ref myRoot);
        //}

        //public TreeNode find(IComparable data)
        //{
        //    return find(data, myRoot);
        //}

        public string traversal(string switchingLetter)
        {
            switch (switchingLetter)
            {
                case "i":
                    return toStringInOrder(myRoot);
                case "r":
                    return toStringPreOrder(myRoot);
                case "o":
                    return toStringPostOrder(myRoot);
                default: return "";
            }
        }

        public int length()
        {
            return myCount;
        }

        public bool isEmpty()
        {
            return myCount == 0;
        }

        private void insert(IComparable data, ref TreeNode ptr)
        {
            if (ptr == null)
            {
                ptr = new TreeNode(data, null, null);
                myCount++;
            }
            else
            {
                int result = data.CompareTo(ptr.myValue);
                if (result <= 0)
                {
                    insert(data, ref ptr.myLeft);
                }
                else
                {
                    insert(data, ref ptr.myRight);
                }
            }
        }

        private string toStringInOrder(TreeNode ptr)
        {
            if (ptr == null) return "";
            else return toStringInOrder(ptr.myLeft) + ptr.myValue + " " + toStringInOrder(ptr.myRight);
        }

        private string toStringPreOrder(TreeNode ptr)
        {
            if (ptr == null) return "";
            else return ptr.myValue + " " + toStringPreOrder(ptr.myLeft) + toStringPreOrder(ptr.myRight);
        }

        private string toStringPostOrder(TreeNode ptr)
        {
            if (ptr == null) return "";
            else return toStringPostOrder(ptr.myLeft) + toStringPostOrder(ptr.myRight) + " " + ptr.myValue;
        }

        //    //where im working on
        //    private TreeNode delete(IComparable data, ref TreeNode ptr)
        //    {
        //        TreeNode returningValue = null;
        //        if (find(data, ptr) == null)
        //        {
        //            return null;
        //        }
        //        else if (find(data, ptr).myLeft == null && find(data, ptr).myRight == null)
        //        {
        //            returningValue = ptr;
        //            ptr = null;
        //        }
        //        else if (find(data, ptr).myLeft == null && find(data, ptr).myRight != null || 
        //            find(data, ptr).myLeft != null && find(data, ptr).myRight == null)
        //        {
        //            returningValue = ptr;
        //            ptr = (ptr.myLeft == null) ? ptr.myRight : ptr.myLeft;
        //        }


        //        return returningValue;
        //    }

        //    private TreeNode find(IComparable data, TreeNode ptr)
        //    {
        //        if (data.CompareTo(ptr.myValue) < 0)
        //        {
        //            find(data, ptr.myLeft); 
        //        }
        //        else if (data.CompareTo(ptr.myValue) > 0)
        //        {
        //            find(data, ptr.myRight);
        //        }
        //        else if (data.CompareTo(ptr.myValue) == 0)
        //        {
        //            return ptr;
        //        }
        //        return null;
        //    }
    }
}
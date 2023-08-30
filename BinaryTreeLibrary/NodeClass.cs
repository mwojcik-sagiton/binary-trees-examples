namespace BinaryTreeLibrary
{
    public class NodeClass
    {
        public string value;
        public int Length;
        public NodeClass? left;
        public NodeClass? right;

        public NodeClass(string x, int length)
        {
            value = x;
            Length = length;
            left = null;
            right = null;
        }
    }
}
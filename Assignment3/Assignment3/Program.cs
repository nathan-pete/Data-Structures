public class BinaryTree
{
    public int Value { get; set; }
    public BinaryTree Left { get; set; }
    public BinaryTree Right { get; set; }

    public BinaryTree(int value)
    {
        Value = value;
    }
}

public class BinaryTreeMain
{
    public BinaryTree Root { get; set; }

    public void Add(int value)
    {
        if (Root == null)
        {
            Root = new BinaryTree(value);
        }
        else
        {
            AddRoot(Root, value);
        }
    }

    private void AddRoot(BinaryTree node, int value)
    {
        if (value < node.Value)
        {
            if (node.Left == null)
            {
                node.Left = new BinaryTree(value);
            }
            else
            {
                AddRoot(node.Left, value);
            }
        }
        else
        {
            if (node.Right == null)
            {
                node.Right = new BinaryTree(value);
            }
            else
            {
                AddRoot(node.Right, value);
            }
        }
    }

    public void inOrder(BinaryTree node, Action<int> action)
    {
        if (node != null)
        {
            inOrder(node.Left, action);
            action(node.Value);
            inOrder(node.Right, action);
        }
    }
}
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

public class MainTree
{
    public BinaryTree Root { get; set; } // node

    public void Add(int value) // add new node to the tree
    {
        if (Root == null)
        {
            Root = new BinaryTree(value);  // if root is null then it will add a new node 
        }
        else
        {
            AddR(Root, value); // if not then it try to find correct way to put new node 
        }
    }

    private void AddR(BinaryTree node, int value)
    {
        if (value < node.Value)
        {
            if (node.Left == null) //  if left node is null, then it creates a new one 
            {
                node.Left = new BinaryTree(value); 
            }
            else
            {
                AddR(node.Left, value);
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
                AddR(node.Right, value);
            }
        }
    }

    public void placeInOrder(BinaryTree node, Action<int> action) // count all actions forr every ndee  
    {
        if (node != null)
        {
            placeInOrder(node.Left, action);
            action(node.Value);
            placeInOrder(node.Right, action); //Call first left then right, all execution will be in correct order
        }
    }
}
public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data)
        {
            // Skip insertion if value already exists
            return;
        }
        
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // If we found the value at the current node
        if (value == Data)
            return true;
            
        // If value is less than current node, search left subtree
        if (value < Data)
            return Left != null && Left.Contains(value);
            
        // If value is greater than current node, search right subtree
        return Right != null && Right.Contains(value);
    }

    public int GetHeight()
    {
        // Get height of left subtree (0 if no left child)
        int leftHeight = Left?.GetHeight() ?? 0;
        
        // Get height of right subtree (0 if no right child)
        int rightHeight = Right?.GetHeight() ?? 0;
        
        // Return 1 (for current node) plus the maximum height between left and right subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
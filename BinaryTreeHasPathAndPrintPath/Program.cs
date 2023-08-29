using MyBinaryTree;
using System.Collections;
using System.Collections.Generic;

#region Input Nodes
NodeClass nodeA = new NodeClass("A");
NodeClass nodeB = new NodeClass("B");
NodeClass nodeC = new NodeClass("C");
NodeClass nodeD = new NodeClass("D");
NodeClass nodeE = new NodeClass("E");
NodeClass nodeF = new NodeClass("F");

// Additional Input Nodes
//NodeClass nodeG = new NodeClass("G");
//NodeClass nodeH = new NodeClass("H");
//NodeClass nodeI = new NodeClass("I");
//NodeClass nodeJ = new NodeClass("J");

nodeA.left = nodeB;
nodeA.right = nodeC;
nodeB.left = nodeD;
nodeB.right = nodeE;
nodeC.right = nodeF;

// Additional Input Nodes paths
//nodeD.left = nodeG;
//nodeE.left = nodeH;
//nodeE.right = nodeI;
//nodeF.right = nodeJ;
#endregion


static bool NodeHasPath(NodeClass rootNode, List<string> path, string a)
{
    // If there is no rootNode, returns false
    if (rootNode == null) return false;

    path.Add(rootNode.value);

    // Maybe rootNode already is the node that we search for
    if (rootNode.value == a) return true;

    // Check if the rootNode.left or rootNode.right is the node we are searching for
    if (NodeHasPath(rootNode.left, path, a) || NodeHasPath(rootNode.right, path, a)) return true;

    path.RemoveAt(path.Count - 1);
    return false;
}

static void PrintPathToNode(NodeClass rootNode, string a)
{
    // List to show path to the node
    List<string> path = new List<string>();

    if (NodeHasPath(rootNode, path, a))
    {
        for (int i = 0; i < path.Count - 1; i++)
        {
            // Print every node value in path(without the last node value) with "--->"
            Console.WriteLine(path[i] + "   --->   ");
        }

        // Print last node value in path without "--->"
        Console.WriteLine(path[path.Count - 1]);
    }

    else
    {
        Console.WriteLine("No Path as there is no node with such value!");
    }
}

PrintPathToNode(nodeA, "E");
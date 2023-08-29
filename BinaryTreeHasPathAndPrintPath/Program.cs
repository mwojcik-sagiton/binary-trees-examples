using MyBinaryTree;
using System.Collections;
using System.Collections.Generic;

NodeClass nodeA = new NodeClass("A");
NodeClass nodeB = new NodeClass("B");
NodeClass nodeC = new NodeClass("C");
NodeClass nodeD = new NodeClass("D");
NodeClass nodeE = new NodeClass("E");
NodeClass nodeF = new NodeClass("F");

nodeA.left = nodeB;
nodeA.right = nodeC;
nodeB.left = nodeD;
nodeB.right = nodeE;
nodeC.right = nodeF;


static bool NodeHasPath(NodeClass firstNode, List<string> path, string a)
{
    // If there is not firstNode, returns false
    if (firstNode == null) return false;

    path.Add(firstNode.value);

    if (firstNode.value == a) return true;

    // Check if the firstNode.left or firstNode.right is the node we are searching for
    if (NodeHasPath(firstNode.left, path, a) || NodeHasPath(firstNode.right, path, a)) return true;

    path.RemoveAt(path.Count - 1);
    return false;
}

static void PrintPathToNode(NodeClass firstNode, string a)
{
    // List to show path to the node
    List<string> path = new List<string>();

    if (NodeHasPath(firstNode, path, a))
    {
        for (int i = 0; i < path.Count - 1; i++)
        {
            // Print every node value in path(without the last node value) with "--->"
            Console.WriteLine(path[i] + "   ->   ");
        }

        // Print last node value in path without "--->"
        Console.WriteLine(path[path.Count - 1]);
    }

    else
    {
        Console.WriteLine("No Path as there is no node with such value!");
    }
}

PrintPathToNode(nodeA, "F");
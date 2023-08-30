
using BinaryTreeLibrary;

namespace BinaryTreeHasPathAndPrintPath
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NodeClass nodeA = new NodeClass("A", 2);
            NodeClass nodeB = new NodeClass("B", 5);
            NodeClass nodeC = new NodeClass("C", 1);
            NodeClass nodeD = new NodeClass("D", 23);
            NodeClass nodeE = new NodeClass("E", 4);
            NodeClass nodeF = new NodeClass("F", 6);
            //NodeClass nodeG = new NodeClass("G", 3);
            NodeClass nodeH = new NodeClass("H", 12);
            NodeClass nodeI = new NodeClass("I", 7);
            //NodeClass nodeJ = new NodeClass("J", 32);

            nodeA.left = nodeB;
            nodeA.right = nodeC;
            nodeB.left = nodeD;
            nodeB.right = nodeE;
            nodeC.right = nodeF;
            //nodeD.left = nodeG;
            nodeE.left = nodeH;
            nodeE.right = nodeI;
            //nodeF.right = nodeJ;

            var paths = GetAllLeavesPaths(nodeA).ToList();

            //print paths for all leaves
            foreach (var leafPath in paths)
            {
                var path = string.Join(" -> ", leafPath.Select(x => x.value));
                var value = leafPath.Select(x => x.Length).Sum();
                Console.WriteLine($"{path}, with value: {value}");
            }

            //Look for maximum path
            var maxPath = paths.Max(x => x.Select(y => y.Length).Sum());
            
            Console.WriteLine($"Maximum path length is {maxPath}");
        }

        //Use recursive method to get paths to all leaves
        private static IEnumerable<List<NodeClass>> GetAllLeavesPaths(NodeClass? node)
        {
            var output = new List<List<NodeClass>>();

            //node might be null so stop further execution
            if (node == null)
            {
                yield break;
            }

            //if there is no further nodes return single element
            if (node.left == null && node.right == null)
            {
                yield return new List<NodeClass>{node};
                yield break;
            }
            
            //Use recursive calls to travers all branches
            output.AddRange(GetAllLeavesPaths(node.left));
            output.AddRange(GetAllLeavesPaths(node.right));

            //Add node value to all incoming elements
            foreach (var value in output)
            {
                value.Insert(0, node);
                yield return value;
            }
        }

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
    }
}
The given binary tree is as follows:

```
      A
     / \
    B   C
   / \   \
  D   E   F
```
But! It could be anything as long as:
- each parent node has up to 2 child nodes;
- there is only one root(first node) in the tree;
- there is only one path from the root to any node;

The task is as follows - we are searching for anykind of node and the path which is leading to it. It
could be a leaf - so the last node as "E" or any node inside a tree like "C". If the node we are searching for
is reachable, the function should return a path to it, if it is not reachable, function will inform that
there is no way to reach that node.

To understand this problem it is best to debug it with breakpoint on line 73 in Program.cs - PrintPathNode(nodeA, "E") and from there go step by step.





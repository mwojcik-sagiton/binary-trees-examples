The given binary tree is as follows:

```
      A
     / \
    B   C
   / \   \
  D   E   F
```
But! It could be anything as long as each parent node has up to 2 child nodes.
The task is as follows - we are searching for anykind of node. It could be a leaf - so the last node as "E"
or any node inside a tree like "C".
To understand this problem it is best to debug it with breakpoint on line 73 in Program.cs - PrintPathNode(nodeA, "E") and from there go step by step.





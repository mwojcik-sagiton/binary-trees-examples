﻿using System;

namespace BinaryTree
{
    public class NodeClass
    {
        public string value;
        public NodeClass? left;
        public NodeClass? right;

        public NodeClass(string x)
        {
            value = x;
            left = null;
            right = null;
        }
    }
}
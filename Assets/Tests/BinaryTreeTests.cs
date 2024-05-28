using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class BinaryTreeTests
{
    [Test]
    public void BinaryTreeTestsSimplePasses()
    {
        BinaryTree<int> myTree = new()
        {
            0,
            1,
            2,
            3,
            4,
            5,
            6
        };
        int index = 0;
        foreach (int i in myTree)
        {
            Assert.AreEqual(index, i);
            index++;
        }
        Assert.AreEqual(0, myTree.GetParent(1));
        Assert.AreEqual(0, myTree.GetParent(2));
        Assert.AreEqual(1, myTree.GetParent(3));
        Assert.AreEqual(1, myTree.GetParent(4));
        Assert.AreEqual(2, myTree.GetParent(5));
        Assert.AreEqual(2, myTree.GetParent(6));
        Assert.AreEqual(1, myTree.GetLeftChild(0));
        Assert.AreEqual(2, myTree.GetRightChild(0));
    }
}

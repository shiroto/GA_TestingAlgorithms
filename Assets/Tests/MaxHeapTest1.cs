using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MaxHeapTest
{
    [Test]
    public void MaxHeapTestSimplePasses()
    {
        MaxHeap<int> maxHeap = new();
        Assert.AreEqual(null, maxHeap.GetRoot());
        maxHeap.Insert(0);
        Assert.AreEqual(0, maxHeap.GetRoot().value);
        maxHeap.Insert(-1);
        Assert.AreEqual(-1, maxHeap.GetRoot().leftChild.value);
        maxHeap.Insert(-2);
        Assert.AreEqual(-2, maxHeap.GetRoot().rightChild.value);
        maxHeap.Insert(-3);
        Assert.AreEqual(-3, maxHeap.GetRoot().leftChild.leftChild.value);
    }

    [Test]
    public void MaxHeapInsertSortTest()
    {
        MaxHeap<int> maxHeap = new();
        Assert.AreEqual(null, maxHeap.GetRoot());
        maxHeap.Insert(0);
        Assert.AreEqual(0, maxHeap.GetRoot().value);
        maxHeap.Insert(-1);
        Assert.AreEqual(-1, maxHeap.GetRoot().leftChild.value);
        maxHeap.Insert(-2);
        Assert.AreEqual(-2, maxHeap.GetRoot().rightChild.value);
        maxHeap.Insert(1);
        Assert.AreEqual(1, maxHeap.GetRoot().value);
        maxHeap.Insert(2);
        Assert.AreEqual(2, maxHeap.GetRoot().value);
        maxHeap.Insert(-5);
        Assert.AreEqual(2, maxHeap.GetRoot().value);
    }

    [Test]
    public void FindLastElementTest()
    {
        MaxHeap<int> maxHeap = new();
        Assert.AreEqual(null, maxHeap.GetRoot());
        maxHeap.Insert(0);
        maxHeap.Insert(-1);
        maxHeap.Insert(-2);
        maxHeap.Insert(-3);
        Assert.AreEqual(-3, maxHeap.FindLastElement().value);
        maxHeap.Insert(-4);
        Assert.AreEqual(-4, maxHeap.FindLastElement().value);
        maxHeap.Insert(-5);
        Assert.AreEqual(-5, maxHeap.FindLastElement().value);
        maxHeap.Insert(-6);
        Assert.AreEqual(-6, maxHeap.FindLastElement().value);
    }

    [Test]
    public void ExtractTest()
    {
        MaxHeap<int> maxHeap = new();
        Assert.AreEqual(null, maxHeap.GetRoot());
        maxHeap.Insert(-5);
        maxHeap.Insert(-2);
        maxHeap.Insert(-0);
        maxHeap.Insert(-1);
        maxHeap.Insert(-4);
        maxHeap.Insert(-3);
        maxHeap.Insert(-6);

        Assert.AreEqual(-0, maxHeap.Extract());
        Assert.AreEqual(-1, maxHeap.Extract());
        Assert.AreEqual(-2, maxHeap.Extract());
        Assert.AreEqual(-3, maxHeap.Extract());
        Assert.AreEqual(-4, maxHeap.Extract());
        Assert.AreEqual(-5, maxHeap.Extract());
        Assert.AreEqual(-6, maxHeap.Extract());
    }

    [Test]
    public void ExtractAndInsertTest()
    {
        MaxHeap<int> maxHeap = new();
        Assert.AreEqual(null, maxHeap.GetRoot());
        maxHeap.Insert(-5);
        maxHeap.Insert(-2);
        maxHeap.Insert(-0);

        Assert.AreEqual(-0, maxHeap.Extract());
        Assert.AreEqual(-2, maxHeap.Extract());
        Assert.AreEqual(-5, maxHeap.Extract());

        maxHeap.Insert(0);
        Assert.AreEqual(0, maxHeap.GetRoot().value);
    }
}

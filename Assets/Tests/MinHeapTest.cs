using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class MinHeapTest
{
    [Test]
    public void MinHeapTestSimplePasses()
    {
        MinHeap<int> minHeap = new();
        Assert.AreEqual(null, minHeap.GetRoot());
        minHeap.Insert(0);
        Assert.AreEqual(0, minHeap.GetRoot().value);
        minHeap.Insert(1);
        Assert.AreEqual(1, minHeap.GetRoot().leftChild.value);
        minHeap.Insert(2);
        Assert.AreEqual(2, minHeap.GetRoot().rightChild.value);
        minHeap.Insert(3);
        Assert.AreEqual(3, minHeap.GetRoot().leftChild.leftChild.value);
    }

    [Test]
    public void MinHeapInsertSortTest()
    {
        MinHeap<int> minHeap = new();
        Assert.AreEqual(null, minHeap.GetRoot());
        minHeap.Insert(0);
        Assert.AreEqual(0, minHeap.GetRoot().value);
        minHeap.Insert(1);
        Assert.AreEqual(1, minHeap.GetRoot().leftChild.value);
        minHeap.Insert(2);
        Assert.AreEqual(2, minHeap.GetRoot().rightChild.value);
        minHeap.Insert(-1);
        Assert.AreEqual(-1, minHeap.GetRoot().value);
        minHeap.Insert(-2);
        Assert.AreEqual(-2, minHeap.GetRoot().value);
        minHeap.Insert(5);
        Assert.AreEqual(-2, minHeap.GetRoot().value);
    }

    [Test]
    public void FindLastElementTest()
    {
        MinHeap<int> minHeap = new();
        Assert.AreEqual(null, minHeap.GetRoot());
        minHeap.Insert(0);
        minHeap.Insert(1);
        minHeap.Insert(2);
        minHeap.Insert(3);
        Assert.AreEqual(3, minHeap.FindLastElement().value);
        minHeap.Insert(4);
        Assert.AreEqual(4, minHeap.FindLastElement().value);
        minHeap.Insert(5);
        Assert.AreEqual(5, minHeap.FindLastElement().value);
        minHeap.Insert(6);
        Assert.AreEqual(6, minHeap.FindLastElement().value);
    }

    [Test]
    public void ExtractTest()
    {
        MinHeap<int> minHeap = new();
        Assert.AreEqual(null, minHeap.GetRoot());
        minHeap.Insert(5);
        minHeap.Insert(2);
        minHeap.Insert(0);
        minHeap.Insert(1);
        minHeap.Insert(4);
        minHeap.Insert(3);
        minHeap.Insert(6);

        Assert.AreEqual(0, minHeap.Extract());
        Assert.AreEqual(1, minHeap.Extract());
        Assert.AreEqual(2, minHeap.Extract());
        Assert.AreEqual(3, minHeap.Extract());
        Assert.AreEqual(4, minHeap.Extract());
        Assert.AreEqual(5, minHeap.Extract());
        Assert.AreEqual(6, minHeap.Extract());
    }

    [Test]
    public void ExtractAndInsertTest()
    {
        MinHeap<int> minHeap = new();
        Assert.AreEqual(null, minHeap.GetRoot());
        minHeap.Insert(5);
        minHeap.Insert(2);
        minHeap.Insert(0);

        Assert.AreEqual(0, minHeap.Extract());
        Assert.AreEqual(2, minHeap.Extract());
        Assert.AreEqual(5, minHeap.Extract());

        minHeap.Insert(0);
        Assert.AreEqual(0, minHeap.GetRoot().value);
    }
}

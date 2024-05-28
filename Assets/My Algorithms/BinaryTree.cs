using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class BinaryTree<T> : IEnumerable<T>, ICollection<T>
{
    private List<T> nodes = new();

    public int Count => nodes.Count;

    public bool IsReadOnly => false;

    public void Add(T node)
    {
        nodes.Add(node);
    }

    public bool Remove(T node)
    {
        T replace = nodes.Last();
        nodes.RemoveAt(nodes.Count - 1);
        for (int i = 0; i < nodes.Count; i++)
        {
            if (node.Equals(nodes[i]))
            {
                nodes[i] = replace;
                return true;
            }
        }
        return false;
    }

    public T GetParent(T child)
    {
        if (child.Equals(nodes[0]))
        {
            throw new InvalidOperationException("Node cannot be the root element.");
        }
        for (int i = 0; i < nodes.Count; i++)
        {
            if (child.Equals(nodes[i]))
            {
                return nodes[GetParentIndex(i)];
            }
        }
        throw new ArgumentException("Node is not part of the tree.");
    }

    public T GetLeftChild(T parent)
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            if (parent.Equals(nodes[i]))
            {
                int childIndex = GetLeftChildIndex(i);
                if (childIndex >= nodes.Count)
                {
                    return default;
                }
                return nodes[childIndex];
            }
        }
        throw new ArgumentException("Node is not part of the tree.");
    }

    public T GetRightChild(T parent)
    {
        for (int i = 0; i < nodes.Count; i++)
        {
            if (parent.Equals(nodes[i]))
            {
                int childIndex = GetRightChildIndex(i);
                if (childIndex >= nodes.Count)
                {
                    return default;
                }
                return nodes[childIndex];
            }
        }
        throw new ArgumentException("Node is not part of the tree.");
    }

    private int GetParentIndex(int childIndex)
    {
        return (childIndex - 1) / 2;
    }

    private int GetLeftChildIndex(int parentIndex)
    {
        return 2 * parentIndex + 1;
    }

    private int GetRightChildIndex(int parentIndex)
    {
        return 2 * parentIndex + 2;
    }

    public IEnumerator<T> GetEnumerator()
    {
        return nodes.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return nodes.GetEnumerator();
    }

    public void Clear()
    {
        nodes.Clear();
    }

    public bool Contains(T item)
    {
        return nodes.Contains(item);
    }

    public void CopyTo(T[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }
}

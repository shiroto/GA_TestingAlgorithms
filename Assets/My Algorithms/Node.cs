using System;
using System.Collections.Generic;

public class Node
{
    public string name;
    private readonly List<Node> neighbors = new();
    private readonly List<float> weights = new();

    public void AddNeighbor(Node node, float weight)
    {
        neighbors.Add(node);
        weights.Add(weight);
        node.neighbors.Add(this);
        node.weights.Add(weight);
    }

    public IReadOnlyList<Node> GetNeighbors()
    {
        return neighbors;
    }

    public IReadOnlyList<float> GetWeights()
    {
        return weights;
    }

    public override string ToString()
    {
        return name;
    }
}

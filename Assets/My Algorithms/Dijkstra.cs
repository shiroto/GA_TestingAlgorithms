using System;
using System.Collections.Generic;

public static class Dijkstra
{
	public static Dictionary<Node, float> Solve(Node root)
	{
		Dictionary<Node, float> distances = new();
		distances[root] = 0;
		MinHeap<DNode> check = new();
		check.Insert(new(root, 0));
		while (check.Count > 0)
		{
			DNode n = check.Extract();
			for (int i = 0; i < n.node.GetNeighbors().Count; i++)
			{
				Node m = n.node.GetNeighbors()[i];
				float newWeight = n.weight + n.node.GetWeights()[i];
				if (!distances.ContainsKey(m) || distances[m] > newWeight)
				{
					distances[m] = newWeight;
					check.Insert(new(m, newWeight));
				}
			}
		}
		return distances;
	}

	private class DNode : IComparable<DNode>
	{
		public Node node;
		public float weight;

		public DNode(Node node, float weight)
		{
			this.node = node;
			this.weight = weight;
		}

		public int CompareTo(DNode other)
		{
			return weight.CompareTo(other.weight);
		}
	}
}
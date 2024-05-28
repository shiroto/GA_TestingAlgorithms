using System.Collections.Generic;
using NUnit.Framework;

public class DijkstraTest
{
	[Test]
	public void Test1()
	{
		Node nodeA = new() { name = "a" };
		Node nodeB = new() { name = "b" };
		Node nodeC = new() { name = "c" };
		Node nodeD = new() { name = "d" };
		Node nodeE = new() { name = "e" };
		Node nodeF = new() { name = "f" };
		Node nodeG = new() { name = "g" };
		Node nodeH = new() { name = "h" };
		Node nodeI = new() { name = "i" };

		nodeA.AddNeighbor(nodeB, 2f);
		nodeA.AddNeighbor(nodeG, 3f);
		nodeA.AddNeighbor(nodeF, 7f);

		nodeB.AddNeighbor(nodeG, 6f);
		nodeB.AddNeighbor(nodeC, 4f);

		nodeC.AddNeighbor(nodeD, 2f);
		nodeC.AddNeighbor(nodeH, 2f);

		nodeD.AddNeighbor(nodeE, 1f);
		nodeD.AddNeighbor(nodeH, 8f);

		nodeE.AddNeighbor(nodeF, 6f);
		nodeE.AddNeighbor(nodeI, 2f);

		nodeF.AddNeighbor(nodeI, 5f);

		nodeG.AddNeighbor(nodeH, 3f);
		nodeG.AddNeighbor(nodeI, 1f);

		nodeH.AddNeighbor(nodeI, 4f);

		Dictionary<Node, float> res = Dijkstra.Solve(nodeA);
		Assert.AreEqual(0, res[nodeA]);
		Assert.AreEqual(2, res[nodeB]);
		Assert.AreEqual(3, res[nodeG]);
		Assert.AreEqual(7, res[nodeF]);
		Assert.AreEqual(4, res[nodeI]);
		Assert.AreEqual(6, res[nodeH]);
		Assert.AreEqual(6, res[nodeC]);
	}
}
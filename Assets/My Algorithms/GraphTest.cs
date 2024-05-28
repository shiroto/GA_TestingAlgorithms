using System.Collections.Generic;
using UnityEngine;

public class GraphTest : MonoBehaviour
{
    // void Start()
    // {

    // }

    // Node BFS(Node root, int target)
    // {
    //     // HashSet<Node> visitedNodes = new();
    //     // Queue<Node> queue = new();
    //     // Node check = root;
    //     // while (check != null)
    //     // {
    //     //     if (check.MyNumber == target)
    //     //     {
    //     //         return check;
    //     //     }
    //     //     foreach (Node n in check.GetNeighbors())
    //     //     {
    //     //         if (!visitedNodes.Contains(n))
    //     //         {
    //     //             queue.Enqueue(n);
    //     //             visitedNodes.Add(n);
    //     //         }
    //     //     }
    //     //     if (queue.Count != 0)
    //     //     {
    //     //         check = queue.Dequeue();
    //     //     }
    //     //     else
    //     //     {
    //     //         check = null;
    //     //     }
    //     // }
    //     // throw new System.Exception("target not found");
    // }

    // Node BFSRec(List<Node> check, int target, HashSet<Node> visitedNodes)
    // {
    //     List<Node> checkNext = new();
    //     foreach (Node n in check)
    //     {
    //         if (visitedNodes.Contains(n))
    //         {
    //             continue;
    //         }
    //         visitedNodes.Add(n);
    //         if (n.MyNumber == target)
    //         {
    //             return n;
    //         }
    //         checkNext.AddRange(n.GetNeighbors());
    //     }
    //     Node res = BFSRec(checkNext, target, visitedNodes);
    //     if (res != null)
    //     {
    //         return res;
    //     }
    //     return null;
    // }

    // Node DFSRec(Node check, int target, HashSet<Node> visitedNodes)
    // {
    //     if (check.MyNumber == target)
    //     {
    //         return check;
    //     }
    //     foreach (Node n in check.GetNeighbors())
    //     {
    //         if (!visitedNodes.Contains(n))
    //         {
    //             visitedNodes.Add(n);
    //             Node res = DFSRec(n, target, visitedNodes);
    //             if (res != null)
    //             {
    //                 return res;
    //             }
    //         }
    //     }
    //     return null;
    // }

    // Node DFS(Node root, int target)
    // {
    //     HashSet<Node> visitedNodes = new();
    //     Stack<Node> stack = new();
    //     Node check = root;
    //     while (check != null)
    //     {
    //         if (check.MyNumber == target)
    //         {
    //             return check;
    //         }
    //         foreach (Node n in check.GetNeighbors())
    //         {
    //             if (!visitedNodes.Contains(n))
    //             {
    //                 stack.Push(n);
    //                 visitedNodes.Add(n);
    //             }
    //         }
    //         if (stack.Count != 0)
    //         {
    //             check = stack.Pop();
    //         }
    //         else
    //         {
    //             check = null;
    //         }
    //     }
    //     throw new System.Exception("target not found");
    // }
}

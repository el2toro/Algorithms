using AlgorithmImplementations.Graphs;

namespace AlgorithmImplementations.Tests;

public class GraphTests
{
    [Fact]
    public void DepthFirstSearch_ShouldReturnDepthOrder()
    {
        var graph = new Graph();

        // Add edges (connections between nodes)
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);
        graph.AddEdge(1, 5);
        graph.AddEdge(3, 8);
        graph.AddEdge(2, 6);
        graph.AddEdge(2, 7);
        graph.AddEdge(6, 9);

        var actual = graph.DepthFirstSearchRecursive(0);

        var expected = new List<int> { 0, 1, 3, 8, 4, 5, 2, 6, 9, 7 };

        Assert.Equal(expected, actual);
    }
}
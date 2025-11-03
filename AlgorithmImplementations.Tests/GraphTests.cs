namespace AlgorithmsImplementations.Tests;

using
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
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 5);

        var order = graph.DepthFirstSearchRecursive(0);

        //Assert
    }
}
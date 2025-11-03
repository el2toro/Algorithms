namespace AlgorithmImplementations.Graphs;

public class Graph<T>
{
    // Dictionary where each key is a vertex (node),
    // and the value is a list of all neighboring vertices (edges)
    private readonly Dictionary<T, List<T>> _adjacency;

    // Whether the graph is directed (edges have direction) or undirected (edges go both ways)
    private readonly bool _isDirected;

    public Graph(bool isDirected = false)
    {
        _adjacency = new Dictionary<T, List<T>>();
        _isDirected = isDirected;
    }

    // Adds a vertex to the graph if it doesn't already exist
    public void AddVertex(T vertex)
    {
        if (!_adjacency.ContainsKey(vertex))
        {
            _adjacency[vertex] = new List<T>(); // initialize empty list of neighbors
        }
    }

    // Adds an edge (connection) between two vertices
    public void AddEdge(T source, T destination)
    {
        AddVertex(source);
        AddVertex(destination);

        // Add the destination to the source’s adjacency list
        _adjacency[source].Add(destination);

        // If the graph is undirected, also add the reverse connection
        if (!_isDirected)
        {
            _adjacency[destination].Add(source);
        }
    }

    // Returns all neighbors of a given vertex
    public IEnumerable<T> GetNeighbors(T vertex)
    {
        return _adjacency.ContainsKey(vertex) ? _adjacency[vertex] : Enumerable.Empty<T>();
    }

    // ---------------------------------------------------------------
    // Breadth-First Search (BFS)
    // ---------------------------------------------------------------

    public List<T> BreadthFirstSearch(T start)
    {
        // This list will store the order in which vertices are visited
        var result = new List<T>();

        // If the start node doesn’t exist in the graph, return empty result
        if (!_adjacency.ContainsKey(start))
        {
            return result;
        }

        // A set to keep track of which vertices have been visited already
        var visited = new HashSet<T>();

        // A queue to process nodes level by level
        var queue = new Queue<T>();

        // Mark the start vertex as visited
        visited.Add(start);

        // Enqueue the start vertex (add to queue)
        queue.Enqueue(start);

        // Loop until there are no more nodes to visit
        while (queue.Count > 0)
        {
            // Take (remove) the vertex from the front of the queue
            var node = queue.Dequeue();

            // Record it in result list
            result.Add(node);

            // Look at each neighbor of this vertex
            foreach (var neighbor in GetNeighbors(node))
            {
                // If we haven’t visited this neighbor yet
                if (!visited.Contains(neighbor))
                {
                    // Mark neighbor as visited (so don’t process it again)
                    visited.Add(neighbor);

                    // Add it to the queue — it will be processed later
                    queue.Enqueue(neighbor);
                }
            }
        }

        // Once queue is empty, return the list of visited vertices in BFS order
        return result;
    }
}

public class Graph
{
    // Dictionary where each node (int) maps to a list of its connected nodes (edges)
    private Dictionary<int, List<int>> adjacencyList = new();
    private List<int> result = new List<int>();

    // Method to add an edge between two nodes
    public void AddEdge(int src, int dest)
    {
        // If the source node doesn't exist yet, create an empty list for it
        if (!adjacencyList.ContainsKey(src))
            adjacencyList[src] = new List<int>();

        // Add the destination node to the source's adjacency list
        adjacencyList[src].Add(dest);
    }

    // Method to return the entire graph structure
    public Dictionary<int, List<int>> GetGraph() => adjacencyList;

    public List<int> DepthFirstSearch(int start)
    {
        // This list will store the order in which vertices are visited
        var visited = new HashSet<int>();
        var stack = new Stack<int>();

        stack.Push(start);

        while (stack.Count > 0)
        {
            int node = stack.Pop();

            // Record it in result list
            result.Add(node);

            if (!visited.Contains(node))
            {
                visited.Add(node);

                if (adjacencyList.ContainsKey(node))
                {
                    // Push neighbors in reverse to visit in correct order
                    var neighbors = adjacencyList[node];
                    for (int i = neighbors.Count - 1; i >= 0; i--)
                        stack.Push(neighbors[i]);
                }
            }
        }

        return result;
    }

    public List<int> DepthFirstSearchRecursive(int start)
    {
        // A set to keep track of all visited nodes (to avoid infinite loops)
        var visited = new HashSet<int>();
        var stack = new Stack<int>();

        if (visited.Contains(start))
            return new List<int>();

        // Mark the current node as visited
        visited.Add(start);
        result.Add(start);

        // If the node has outgoing edges (neighbors), explore them
        if (adjacencyList.ContainsKey(start))
        {
            // Visit each connected node (neighbor)
            foreach (var neighbor in adjacencyList[start])
            {
                // Recursively call DFS on each neighbor
                DepthFirstSearchRecursive(neighbor);
            }
        }

        return result;
    }
}
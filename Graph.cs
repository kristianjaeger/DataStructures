using System;

namespace DataStructures
{
    // http://msdn.microsoft.com/en-us/library/ms379574(v=vs.80).aspx has a good explanation of graphs
    class Graph
    {
	    private GraphNode[] vertices;
	    public int Count;
	    
        public Graph() 
        {
		    vertices = new GraphNode[6];
		    Count = 0;
        }
	
        public void AddNode(GraphNode x) 
        {
		    if (Count < 30) 
            {
			    vertices[Count] = x;
			    Count++;
		    } 
            else 
            {
			    Console.WriteLine("Graph full");
		    }
        }
    
        public GraphNode[] GetNodes() 
        {
            return vertices;
        }
    }
}
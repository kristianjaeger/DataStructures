using System;

namespace DataStructures
{
    class GraphNode
    {
        private GraphNode[] adjacent;
        public int AdjacentCount;
        private String vertex;
        public State state;
    
        public GraphNode(String vertex, int adjacentLength) 
        {
            this.vertex = vertex;                
            AdjacentCount = 0;        
            adjacent = new GraphNode[adjacentLength];
        }
    
        public void AddAdjacent(GraphNode x) 
        {
            if (AdjacentCount < 30) 
            {
                adjacent[AdjacentCount] = x;
                AdjacentCount++;
            } 
            else 
            {
                Console.WriteLine("No more adjacent can be added");
            }
        }

        public GraphNode[] GetAdjacent() 
        {
            return adjacent;
        }
    
        public String GetVertex() 
        {
            return vertex;
        }
    }

    public enum State 
    {
		Unvisited, Visited, Visiting
	} 
}
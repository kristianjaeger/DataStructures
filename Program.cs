using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine();

		    var graph = CreateNewGraph();
		    var nodeArray = graph.GetNodes();
            var start = nodeArray[3];
            var end = nodeArray[5];

            // Is there a path from start to end?
		    Console.WriteLine(Search(graph, start, end));

            Console.WriteLine();
            Console.WriteLine(DateTime.Now.Millisecond);

            var dummy = Console.ReadLine();
        }

        public static Graph CreateNewGraph()
        {
            var graph = new Graph();
            var graphNodeArray = new GraphNode[6];

            graphNodeArray[0] = new GraphNode("Alabama", 3);
            graphNodeArray[1] = new GraphNode("Brazil", 0);
            graphNodeArray[2] = new GraphNode("California", 0);
            graphNodeArray[3] = new GraphNode("Delaware", 1);
            graphNodeArray[4] = new GraphNode("Ecuador", 1);
            graphNodeArray[5] = new GraphNode("Florida", 0);

            graphNodeArray[0].AddAdjacent(graphNodeArray[1]);
            graphNodeArray[0].AddAdjacent(graphNodeArray[2]);
            graphNodeArray[0].AddAdjacent(graphNodeArray[3]);
            graphNodeArray[3].AddAdjacent(graphNodeArray[4]);
            graphNodeArray[4].AddAdjacent(graphNodeArray[5]);

            for (var loopCounter = 0; loopCounter < 6; loopCounter++)
            {
                graph.AddNode(graphNodeArray[loopCounter]);
            }

            return graph;
        }

       public static bool Search(Graph graph, GraphNode start, GraphNode end) 
       {  
           var nodeList = new LinkedList<GraphNode>();

           foreach (var graphNode in graph.GetNodes())
           {
               graphNode.state = State.Unvisited;
           }

           start.state = State.Visiting;
           nodeList.AddLast(start);
           GraphNode unvisited = null;
           
           while(nodeList.Count > 0)
           {
                unvisited = nodeList.First.Value;
                nodeList.RemoveFirst();

                if (unvisited != null) 
                {
	                foreach (var node in unvisited.GetAdjacent()) 
                    {
	                    if (node.state == State.Unvisited) 
                        {
	                        if (node == end) 
                            {
                                Console.WriteLine(node.GetVertex());
	                            return true;
	                        } 
                            else 
                            {
	                            node.state = State.Visiting;
	                            nodeList.AddLast(node);
	                        }
	                    }
	                }
	                unvisited.state = State.Visited;
                }
            }

            return false;
        }
    }
}
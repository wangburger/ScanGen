using System;
using System.Collections.Generic;
using System.Text;

namespace GraphLibrary
{
    /// <summary>
    /// A basic representation of a Graph.  
    /// </summary>
    public class Graph
    {
        List<BaseVertex> vertices;


        /// <summary>
        /// Creates a new Graph with no Vertices.  
        /// </summary>
        public Graph()
        {
            vertices = new List<BaseVertex>();
        }


        /// <summary>
        /// The list of Vertices present in this graph.  
        /// </summary>
        public List<BaseVertex> Vertices
        {
            get
            {
                return vertices;
            }
        }


        /// <summary>
        /// Creates and returns a new BaseVertex with the given name and adds it to the graph
        /// </summary>
        /// <param name="name">The name of the vertex to be added.  The name must be unique.  </param>
        /// <returns>The new Vertex which was just created</returns>
        public BaseVertex CreateNewVertex(string name)
        {
            BaseVertex newV = new BaseVertex(name);
            vertices.Add(newV);
            return newV;
        }


        /// <summary>
        /// Creates a new vertex with a name equal to the current length of the vertex list
        /// </summary>
        /// <returns>The new Vertex which was just created.  </returns>
        public BaseVertex CreateNewVertex()
        {
            return this.CreateNewVertex("" + vertices.Count);
        }


        /// <summary>
        /// Removes the given Vertex from the graph; also removes all edges which use this vertex.  
        /// </summary>
        /// <param name="toRemove">The Vertex which will be completely removed from the graph.  </param>
        public void RemoveVertex(BaseVertex toRemove)
        {
            vertices.Remove(toRemove);

            foreach (BaseVertex vtx in vertices)
                vtx.RemoveConnections(toRemove);
        }

        /// <summary>
        /// Stores this graph in the DOT format to show in graphviz
        /// </summary>
        /// <param name="graphName">The name of this graph.</param>
        /// <returns></returns>
        public String ToDOT(String graphName)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("digraph ");
            sb.Append(graphName);
            sb.Append("{\n");
            foreach (BaseVertex vertex in vertices)
            {
                foreach (Edge edge in vertex.Connections)
                {
                    //label format
                    //\t v1 -> v2 [label="<edge text here>"]; \n

                    sb.Append("\t ");
                    sb.Append(vertex.Name);
                    sb.Append(" -> ");
                    sb.Append(edge.Connection.Name);
                    sb.Append(" [label=\"");
                    sb.Append(edge.EdgeText);
                    sb.Append("\"];\n");
                }
            }
            sb.Append("}");

            return sb.ToString();
        }

    }
}

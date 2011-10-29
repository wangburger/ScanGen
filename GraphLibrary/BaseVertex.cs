using System;
using System.Collections.Generic;
using System.Text;

namespace GraphLibrary
{
    public class BaseVertex
    {
        List<Edge> connectsTo;
        string name;

        /// <summary>
        /// Creates a new vertex with a given name and no connections.  
        /// </summary>
        /// <param name="name"></param>
        public BaseVertex(string name)
        {
            this.name = name;
            connectsTo = new List<Edge>();
        }

        /// <summary>
        /// The name of this vertex
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = Name;
            }
        }

        /// <summary>
        /// The list of edges that this vertex connects to.  
        /// </summary>
        public List<Edge> Connections
        {
            get
            {
                return connectsTo;
            }
        }


        /// <summary>
        /// Removes all connections from this Vertex to a given target Vertex.
        /// </summary>
        /// <param name="target">Any connections from the current Vertex to target will be removed.</param>
        public void RemoveConnections(BaseVertex target)
        {
            for (int i = 0; i < connectsTo.Count; i++)
            {
                if (connectsTo[i].Connection.Name == target.Name)
                {
                    connectsTo.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Removes a specific Edge from this Vertex.  
        /// </summary>
        /// <param name="toRemove">Removes a specific edge from this Vertex</param>
        public void RemoveConnections(Edge toRemove)
        {
            connectsTo.Remove(toRemove);
        }
    }
}

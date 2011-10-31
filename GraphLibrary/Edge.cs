using System;
using System.Collections.Generic;
using System.Text;

namespace GraphLibrary
{
    /// <summary>
    /// This class represents an Edge in a directed graph which is only valid when a given condition is met.  
    /// </summary>
    public class Edge
    {
        BaseVertex connectsTo;
        string validOnCondition;
        string edgeText;

        /// <summary>
        /// Creates a new Edge with the given target Vertex and condition
        /// </summary>
        /// <param name="nextVertex">The vertex pointed to by this edge.  </param>
        /// <param name="condition">The condition which must be true for this vertex to be valid.</param>
        public Edge(BaseVertex nextVertex, string condition)
        {
            connectsTo = nextVertex;
            validOnCondition = condition;
            edgeText = String.Empty;
        }
        /// <summary>
        /// Creates a new Edge with the given target Vertex and condition
        /// </summary>
        /// <param name="nextVertex">The vertex pointed to by this edge.  </param>
        /// <param name="condition">The condition which must be true for this vertex to be valid.</param>
        /// <param name="edgeText">The text to show on for this edge</param>
        public Edge(BaseVertex nextVertex, string condition, string edgeText)
        {
            connectsTo = nextVertex;
            validOnCondition = condition;
            this.edgeText = edgeText;
        }

        /// <summary>
        /// The vertex pointed to by the edge
        /// </summary>
        public BaseVertex Connection
        {
            get
            {
                return connectsTo;
            }
            set
            {
                connectsTo = value;
            }
        }
        /// <summary>
        /// The condition which must be met for the edge to be valid.  
        /// </summary>
        public string Condition
        {
            get
            {
                return validOnCondition;
            }
            set
            {
                validOnCondition = value;
            }
        }
        /// <summary>
        /// The text displayed on the edge of this graph
        /// </summary>
        public string EdgeText
        {
            get { return edgeText; }
        }

        public override bool Equals(object obj)
        {
            if (obj is Edge)
            {
                Edge o = (Edge) obj;
                if (connectsTo.Name == o.Connection.Name && this.validOnCondition.Equals(o.Condition))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

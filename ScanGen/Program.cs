using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphLibrary;

namespace ScanGen
{
    class Program
    {
        static void Main(string[] args)
        {

            Graph graph = new Graph();
            BaseVertex v1 = graph.CreateNewVertex("node1");
            BaseVertex v2 = graph.CreateNewVertex("node2");
            BaseVertex v3 = graph.CreateNewVertex("node3");
            BaseVertex v4 = graph.CreateNewVertex("node4");
            v1.Connections.Add(new Edge(v1, "", "a"));
            v1.Connections.Add(new Edge(v2, "", "a"));
            v1.Connections.Add(new Edge(v3, "", "a"));
            v1.Connections.Add(new Edge(v4, "", "a"));

            v1.Connections.Add(new Edge(v2, "", "b"));
            v1.Connections.Add(new Edge(v4, "", "b"));


            String s = graph.ToDOT("testgraph");
            Console.WriteLine(s);
        }
    }
}

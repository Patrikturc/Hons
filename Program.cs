using QuikGraph.Data;
using System;
using System.Data;
using QuikGraph.Algorithms;
using System.IO;
using QuikGraph;
using QuikGraph.Graphviz;
using System.Collections.Generic;
using Hons_Project_Console_testin;

namespace quickGraph
{
    class Program
    {
        public static List<int[]> map;


        static void Main(string[] args)
        {
            
            var graph2 = new AdjacencyGraph<int, Edge<int>>();
            var graph3 = new AdjacencyGraph<nodeData, Edge<nodeData>>();

            graph2.AddVertex(42);
            graph2.AddVertex(43);
            graph2.AddVertex(44);
            graph2.AddVertex(45);
            Edge<int> evv;
            graph3.AddVertex(new Edge<nodeData>(new nodeData(new vec2(0, 0), 42)),
                             new Edge<nodeData>(new nodeData(new vec2(0, 0), 42)));
            graph2.AddEdge(new Edge<int>(42, 43));
            graph2.AddEdge(new Edge<int>(42, 44));
            int c = graph2.VertexCount;
            int e = graph2.EdgeCount;

            Console.ReadLine();

            map = new List<int[]>();
            //generateMoves();
            //Console.ReadKey();

        }

        /// <summary>
        /// Algorithm to generate states to be inserted into a graph
        /// </summary>
        static public void generateMoves()
        {

            int[] temp = new int[9];
            int count = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            for (int m = 0; m < 3; m++)
                            {
                                for (int n = 0; n < 3; n++)
                                {
                                    for (int o = 0; o < 3; o++)
                                    {
                                        for (int p = 0; p < 3; p++)
                                        {
                                            for (int q = 0; q < 3; q++)
                                            {
                                                temp[0] = i;
                                                temp[1] = j;
                                                temp[2] = k;
                                                temp[3] = l;
                                                temp[4] = m;
                                                temp[5] = n;
                                                temp[6] = o;
                                                temp[7] = p;
                                                temp[8] = q;


                                                if (Valid.check(temp))
                                                {
                                                    //Console.WriteLine(count + ") ");
                                                    WinCheck.Win(temp);
                                                    //Console.WriteLine(count);
                                                    //print(temp);
                                                    map.Add(temp);


                                                    count++;
                                                    Console.WriteLine();
                                                }

                                                temp = new int[9];
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            var graph = new AdjacencyGraph<int[], Edge<int[]>>();

            //add all board states to graph as vertices
            /*for (int i = 0; i < map.Count; i++)
            {
                graph.AddVertex(map[i]);
            }

            //if connect conditions are met then connect vertices with edges
            for (int i = 0; i < map.Count; i++)
            {
                for (int j = 0; j < map.Count; j++)
                {
                    if (Connected.connect(map[i], map[j]))
                    {
                        
                        Edge<int[]> a = new Edge<int[]>(map[i], map[j]);//make new edge
                        graph.AddEdge(a);  //connect edge

                    }
                }
            }
            int c = 0;
            foreach (var vertex in graph.Vertices)
            {
                foreach (var edge in graph.OutEdges(vertex))
                {
                    print(vertex);
                    Console.WriteLine(edge);
                    c++;
                }
            }
            Console.WriteLine(c);
            //Function that takes an edge and returns a double as weight
            //graph.ShortestPathsAStar(graph.ed, );*/
        }

        /// <summary>
        /// Pring Method
        /// </summary>
        /// <param name="map"></param>
        public static void print(int[] map)
        {
            for (int i = 0; i < map.Length; i++)
            {
                if (i == 2 || i == 5 || i == 8) Console.WriteLine(map[i]);

                else Console.Write(map[i] + " ");
            }
        }
    }

    public class vec2
    {
        public double x_;
        public double y_;

        public vec2(double x, double y)
        {
            x_ = x;
            y_ = y;
        }
    }

    public class nodeData
    {
        public vec2 v_;
        public int id_;

        public nodeData(vec2 v, int id)
        {
            v_ = v;
            id_ = id;
        }
    }

}


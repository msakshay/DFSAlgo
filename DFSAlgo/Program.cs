using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DFSAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DFSAlgo g = new DFSAlgo(5);

            g.AppendEdge(0, 1);
            g.AppendEdge(0, 2);
            //g.AppendEdge(1, 2);
            g.AppendEdge(1, 4);
            g.AppendEdge(2, 0);
            g.AppendEdge(2, 3);
            g.AppendEdge(3, 3);
            g.AppendEdge(4, 1);

            g.DFS();
            Console.ReadLine();
        }
    }

    /// <summary>
    /// With adjecency vertex
    /// </summary>
    internal class DFSAlgo
    {
        private List<int>[] _list;
        private int _vertices;
        bool[] visited;

        public DFSAlgo(int v)
        {
            visited = new bool[v];
            _list = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                _list[i] = new List<int>();
            }
            _vertices = v;
            
        }

        public void AppendEdge(int currEdge, int newEdge)
        {
            _list[currEdge].Add(newEdge);
        }

        public void DFS()
        {
            for(int i = 0; i < _vertices; i++)
            {
                if(!visited[i])
                {
                    DFSUtil(i);
                }
            }
        }

        private void DFSUtil(int v)
        {
            visited[v] = true;
            Console.Write(v + " ");

            foreach(int vertex in _list[v])
            {
                if(!visited[vertex])
                    DFSUtil(vertex);
            }
        }
    }
}

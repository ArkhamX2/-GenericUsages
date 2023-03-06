using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnALibrary
{

    /// <summary>
    /// Граф
    /// </summary>
    public class MyGraph
    {
        int _countVertices;
        int[,] _adjacencyMatrix;
        List<List<int>> _adjacencyList;

        public MyGraph()
        {
            _countVertices = 0;
            _adjacencyMatrix = new int[0,0];
        }

        public MyGraph(int[,] adjacencyMatrix)
        {
            _adjacencyMatrix = adjacencyMatrix;
            _countVertices = adjacencyMatrix.GetUpperBound(0)+1;
            _adjacencyList = GetAdjacencyListByMatrix(adjacencyMatrix);
        }

        public int[,] GetAdjacencyMatrix
        {
            get{ return _adjacencyMatrix; }
        }

        public List<List<int>> GetAdjacencyList
        {
            get { return _adjacencyList; }
        }
         
        public int Count
        {
            get { return _countVertices; }
        }

        private List<List<int>> GetAdjacencyListByMatrix(int[,] adjacencyMatrix)
        {
            List<List<int>> adjacencyList = new List<List<int>>();
            for (int vertexIndex = 0; vertexIndex < _countVertices; vertexIndex++)
            {
                List<int> vertexAdjacentVertices = GetVertexAdjacentVertices(adjacencyMatrix,vertexIndex);
                adjacencyList.Add(vertexAdjacentVertices);
            }
            return adjacencyList;
        }

        private List<int> GetVertexAdjacentVertices(int[,] adjacencyMatrix, int vertexIndex)
        {
            List<int> vertices = new List<int>();
            for (int j = 0; j < _countVertices; j++)
            {
                if (adjacencyMatrix[vertexIndex, j] != 0)
                {
                    vertices.Add(j);
                }
            }

            return vertices;
        }


        public void BreadthFirstSearch(int startIndex)
        {
            List<int> visitedVertices = new List<int>();
            visitedVertices.Add(startIndex);

            Queue<int> verticesQueue = new Queue<int>();
            verticesQueue.Enqueue(startIndex);

            while(verticesQueue.Count != 0)
            {
                int curVertex = verticesQueue.Dequeue();
                foreach (int neighbour in _adjacencyList[curVertex])
                {
                    if (!visitedVertices.Contains(neighbour))
                    {
                        Console.WriteLine(curVertex +"->"+neighbour);
                        visitedVertices.Add(neighbour);
                        verticesQueue.Enqueue(neighbour);
                    }
                }
            }

        }
        public void BreadthFirstSearchMatrix(int startIndex)
        {
            List<int> visitedVertices = new List<int>();
            visitedVertices.Add(startIndex);

            Queue<int> verticesQueue = new Queue<int>();
            verticesQueue.Enqueue(startIndex);

            while (verticesQueue.Count != 0)
            {
                int curVertex = verticesQueue.Dequeue();

                for (int i = 0; i < Count; i++)
                {
                    int neighbour = _adjacencyMatrix[curVertex, i];
                    if (neighbour != 0)
                    {
                        if (!visitedVertices.Contains(i))
                        {
                            Console.WriteLine(curVertex + "->" + i);
                            visitedVertices.Add(i);
                            verticesQueue.Enqueue(i);
                        }
                    }
                }

            }

        }

        public void DepthFirstSearch(int startIndex)
        {
            List<int> visitedVertices = new List<int>();
            visitedVertices.Add(startIndex);
            DFS(startIndex, visitedVertices);
        }

        private void DFS(int startIndex, List<int> visitedVertices)
        {
            foreach (int neighbour in _adjacencyList[startIndex])
            {
                if (!visitedVertices.Contains(neighbour))
                {
                    Console.WriteLine(startIndex + "->" + neighbour);
                    visitedVertices.Add(neighbour);
                    DFS(neighbour,visitedVertices);
                }
            }
        }

        public void DepthFirstSearchMatrix(int startIndex)
        {
            List<int> visitedVertices = new List<int>();
            visitedVertices.Add(startIndex);
            DFSMatrix(startIndex, visitedVertices);
        }

        private void DFSMatrix(int startIndex, List<int> visitedVertices)
        {
            for (int i = 0; i < Count; i++)
            {
                int neighbour = _adjacencyMatrix[startIndex, i];
                if (!visitedVertices.Contains(i))
                {
                    Console.WriteLine(startIndex + "->" + i);
                    visitedVertices.Add(i);
                    DFSMatrix(i, visitedVertices);
                }
            }
        }

        public int CountPaths(int start, int destination)
        {
            int pathCount = 0;
            bool[] isVisited = new bool[Count];
            pathCount = CountPathsUtil(start, destination, pathCount, isVisited);
            return pathCount;
        }

        private int CountPathsUtil(int start, int destination, int pathCount, bool[] isVisited)
        {
            isVisited[start] = true;
            if (start == destination)
            {
                pathCount++;
            }
            else
            {
                foreach(int adjacent in _adjacencyList[start])
                {
                    if (!isVisited[adjacent])
                    {
                        pathCount = CountPathsUtil(adjacent, destination, pathCount, isVisited);
                    }
                    
                }
            }

            isVisited[start] = false;
            return pathCount;
        }

        public void PrintAllPaths(int start, int destination)
        {
            bool[] isVisited = new bool[_countVertices];
            List<int> pathList = new List<int>();
            int pathLength = 0;

            pathList.Add(start);
            
            PrintAllPathsUtil(start, destination, isVisited, pathList);
        }

        private void PrintAllPathsUtil(int start, int destination, bool[] isVisited, List<int> localPathList)
        {

            if(start == destination)
            {
                Console.WriteLine(string.Join(" ", localPathList)+" Длина: " + GetPathLength(localPathList));
                return;
            }

            isVisited[start] = true;

            foreach(int nextVertex in _adjacencyList[start])
            {
                if (!isVisited[nextVertex])
                {
                    localPathList.Add(nextVertex);
                    PrintAllPathsUtil(nextVertex, destination, isVisited, localPathList);
                    localPathList.Remove(nextVertex);
                }
            }

            isVisited[start] = false;
        }

        private int GetPathLength(List<int> path)
        {
            int length = 0;
            for (int i = 0; i < path.Count-1; i++)
            {
                length += _adjacencyMatrix[path[i], path[i + 1]];
            }
            return length;
        }
    }
}

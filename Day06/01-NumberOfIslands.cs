using System;
using System.Linq;

namespace AlgorithmII.Day06
{
    public class NumberOfIslands
    {
        public static void Run()
        {
            var problem = new NumberOfIslands();
            var result = problem.NumIslands(new char[][]
            {
                new char[] {'1', '1', '1', '1', '0'},
                new char[] {'1', '1', '0', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '0', '0'},
            });

            Console.WriteLine(result);
        }


        private bool[][] _visited;
        private char[][] _grid;
        private int _rowLength;
        private int _columnLength;

        public int NumIslands(char[][] grid)
        {
            _visited = grid.Select(row => new bool[row.Length]).ToArray();
            _grid = grid;
            _rowLength = grid[0].Length;
            _columnLength = grid.Length;
            var islandCount = 0;
            // ['1','1','1','1','0'],
            // ['1','1','0','1','0'],
            // ['1','1','0','0','0'],
            // ['0','0','0','0','0']
            for (var i = 0; i < grid.Length; i++)
            {
                var row = grid[i];
                for (var j = 0; j < row.Length; j++)
                {
                    if (_visited[i][j])
                    {
                        continue;
                    }
                    
                    if (grid[i][j] == '0')
                    {
                        _visited[i][j] = true;
                        continue;
                    }

                    Visit(i, j);
                    islandCount++;
                }
            }


            return islandCount;
        }

        private void Visit(int i, int j)
        {
            if (i < 0 || j < 0 || i >= _columnLength || j >= _rowLength || _visited[i][j] || _grid[i][j] == '0')
                return;

            _visited[i][j] = true;
            Visit(i, j + 1);
            Visit(i, j - 1);
            Visit(i - 1, j);
            Visit(i + 1, j);
        }
    }
}
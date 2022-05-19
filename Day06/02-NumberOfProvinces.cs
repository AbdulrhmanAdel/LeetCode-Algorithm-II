using System.Security.Cryptography.X509Certificates;

namespace AlgorithmII.Day06
{
    public class NumberOfProvinces
    {
        public int FindCircleNum(int[][] isConnected)
        {
            var visited = new int[isConnected.Length];

            void Visit(int i)
            {
                for (var j = 0; j < isConnected.Length; j++)
                {
                    if (isConnected[i][j] != 1 || visited[j] != 0) continue;

                    visited[j] = 1;
                    Visit(j);
                }
            }

            var count = 0;
            for (var i = 0; i < isConnected.Length; i++)
            {
                if (visited[i] != 0) continue;
                
                Visit(i);
                count++;
            }

            return count;
        }
    }
}
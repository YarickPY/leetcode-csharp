namespace LeetCode
{
    public class LC0200_NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null || grid.Length == 0) return 0;
            int numIslands = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        numIslands++;
                        Dfs(grid, i, j);
                    }
                }
            }
            return numIslands;
        }

        /// <summary>
        /// Depth-first search to mark all connected land cells ('1') as visited ('0').
        /// </summary>
        private void Dfs(char[][] grid, int i, int j)
        {
            if (i < 0               ||
                i >= grid.Length    ||
                j < 0               ||
                j >= grid[i].Length ||
                grid[i][j] == '0')
            {
                return;
            }

            // Set the current cell to mark it as visited
            grid[i][j] = '0';
            Dfs(grid, i + 1, j);
            Dfs(grid, i - 1, j);
            Dfs(grid, i, j + 1);
            Dfs(grid, i, j - 1);
        }
    }
}

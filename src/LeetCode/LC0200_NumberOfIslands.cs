namespace LeetCode
{
    public class LC0200_NumberOfIslands
    {
        public int NumIslands(char[][] grid)
        {
            if (grid == null ||
                grid.Length == 0 ||
                grid[0].Length == 0)
            { 
                return 0;
            }

            int rows = grid.Length;
            int cols = grid[0].Length;
            int numIslands = 0;

            for (int col = 0; col < rows; col++)
            {
                for (int row = 0; row < cols; row++)
                {
                    if (grid[col][row] == '1')
                    {
                        numIslands++;
                        Dfs(grid, col, row);
                    }
                }
            }
            return numIslands;
        }

        /// <summary>
        /// Depth-first search to mark all connected land cells ('1') as visited ('0').
        /// </summary>
        private void Dfs(char[][] grid, int col, int row)
        {
            if (col < 0                 ||
                col >= grid.Length      ||
                row < 0                 ||
                row >= grid[col].Length ||
                grid[col][row] == '0')
            {
                return;
            }

            // Set the current cell to mark it as visited
            grid[col][row] = '0';
            Dfs(grid, col + 1, row);
            Dfs(grid, col - 1, row);
            Dfs(grid, col, row + 1);
            Dfs(grid, col, row - 1);
        }
    }
}

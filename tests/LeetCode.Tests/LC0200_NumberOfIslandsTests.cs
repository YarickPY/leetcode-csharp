namespace LeetCode.Tests
{
    public class LC0200_NumberOfIslandsTests
    {
        public static IEnumerable<object[]> TestCases()
        {
            yield return new object[]
            {
                new char[][]
                {
                    new[] { '1', '1', '1', '1', '0' },
                    new[] { '1', '1', '0', '1', '0' },
                    new[] { '1', '1', '0', '0', '0' },
                    new[] { '0', '0', '0', '0', '0' }
                },
                1
            };

            yield return new object[]
            {
                new char[][]
                {
                    new[] { '1', '1', '0', '0', '0' },
                    new[] { '1', '1', '0', '0', '0' },
                    new[] { '0', '0', '1', '0', '0' },
                    new[] { '0', '0', '0', '1', '1' }
                },
                3
            };

            // Edge case: single cell, land
            yield return new object[]
            {
                new char[][]
                {
                    new[] { '1' }
                },
                1
            };

            // Edge case: single cell, water
            yield return new object[]
            {
                new char[][]
                {
                    new[] { '0' }
                },
                0
            };

            // Edge case: all water
            yield return new object[]
            {
                new char[][]
                {
                    new[] { '0', '0' },
                    new[] { '0', '0' }
                },
                0
            };
        }

        [Theory]
        [MemberData(nameof(TestCases))]
        public void NumIslands_ReturnsExpectedCount(char[][] grid, int expected)
        {
            // Local instantiation for behavioral isolation
            var solution = new LC0200_NumberOfIslands();

            var actual = solution.NumIslands(grid);

            Assert.Equal(expected, actual);
        }
    }
}

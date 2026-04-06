using Xunit;

public class ProgramTests
{
    [Fact]
    public void ReplaceLessThanK_Works()
    {
        double[] arr = { 1, 5, 2 };
        double[] result = Program.ReplaceLessThanK(arr, 3);

        Assert.Equal(new double[] { 3, 5, 3 }, result);
    }

    [Fact]
    public void MinElementIndexes_Works()
    {
        double[] arr = { 5, 1, 3, 1 };

        var result = Program.MinElementIndexes(arr);

        Assert.Equal(new int[] { 1, 3 }, result);
    }

    [Fact]
    public void SwapRowsMatrix_Even()
    {
        int[,] matrix =
        {
            {1,2},
            {3,4}
        };

        var result = Program.SwapRowsMatrix(matrix);

        Assert.Equal(3, result[0,0]);
        Assert.Equal(4, result[0,1]);
    }

    [Fact]
    public void SwapRowsMatrix_Odd()
    {
        int[,] matrix =
        {
            {1,2},
            {3,4},
            {5,6}
        };

        var result = Program.SwapRowsMatrix(matrix);

        Assert.Equal(3, result[0,0]);
    }

    [Fact]
    public void FirstPositivePerColumn_Works()
    {
        int[][] arr =
        {
            new int[] { -1, 2, -3 },
            new int[] { 4, -5, 6 }
        };

        var result = Program.FirstPositivePerColumn(arr);

        Assert.Equal(new int[] { 4, 2, 6 }, result);
    }
}
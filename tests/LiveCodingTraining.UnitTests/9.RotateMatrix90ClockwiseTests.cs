using LiveCodingTraining.TenBest;

namespace LiveCodingTraining.UnitTests;

public class RotateMatrix90ClockwiseTests
{
    [Fact]
    public void RotateMatrix90Clockwise_With3x3_RotatesCorrectly()
    {
        int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];

        LiveCodingPractice.RotateMatrix90Clockwise(matrix);

        Assert.Equal([[7, 4, 1], [8, 5, 2], [9, 6, 3]], matrix);
    }

    [Fact]
    public void RotateMatrix90Clockwise_With2x2_RotatesCorrectly()
    {
        int[][] matrix = [[1, 2], [3, 4]];

        LiveCodingPractice.RotateMatrix90Clockwise(matrix);

        Assert.Equal([[3, 1], [4, 2]], matrix);
    }

    [Fact]
    public void RotateMatrix90Clockwise_With1x1_RemainsSame()
    {
        int[][] matrix = [[42]];

        LiveCodingPractice.RotateMatrix90Clockwise(matrix);

        Assert.Equal([[42]], matrix);
    }

    [Fact]
    public void RotateMatrix90Clockwise_With2x3_ThrowsArgumentException()
    {
        int[][] matrix = [
            [1, 2, 3],
            [4, 6, 6]
        ];

        var ex = Record.Exception(() => LiveCodingPractice.RotateMatrix90Clockwise(matrix));

        Assert.IsType<ArgumentException>(ex);
    }

    

    [Fact]
    public void RotateMatrix90Clockwise_With1x3_2x4_ThrowsArgumentException()
    {
        int[][] matrix = [
            [1, 2, 3],
            [4, 6, 6, 7]
        ];

        var ex = Record.Exception(() => LiveCodingPractice.RotateMatrix90Clockwise(matrix));

        Assert.IsType<ArgumentException>(ex);
    }

    [Fact]
    public void RotateMatrix90Clockwise_With2x3_ThrowsArgumentNullException()
    {
        int[][] matrix = null;

        var ex = Record.Exception(() => LiveCodingPractice.RotateMatrix90Clockwise(matrix));

        Assert.IsType<ArgumentNullException>(ex);
    }
}

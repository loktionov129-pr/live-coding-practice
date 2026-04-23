using LiveCodingTraining.TenBest;

namespace LiveCodingTraining.UnitTests;

public class TwoSumTests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 1, 2, 4, 6, 10 }, 8, new[] { 1, 3 })]
    [InlineData(new[] { -3, -1, 0, 2, 4, 9 }, 1, new[] { 0, 4 })]
    [InlineData(new[] { 1, 3, 4, 5, 7, 10, 11 }, 15, new[] { 2, 6 })]
    public void TwoSum_WithSortedArray_ReturnsExpectedIndexes(int[] numbers, int target, int[] expected)
    {
        int[] result = LiveCodingPractice.TwoSum(numbers, target);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSum_WithSortedArray_ThrowsException()
    {
        // Given
        var numbers = new[] { 1, 3, 4, 5, 7, 10, 11 };
        // When
        var ex = Record.Exception(() => LiveCodingPractice.TwoSum(numbers, 42));

        // Then
        Assert.IsType<ArgumentException>(ex);
    }
}

namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// Повернуть квадратную матрицу на 90 градусов по часовой стрелке in-place.
    /// Пример: RotateMatrix90Clockwise(new[] {
    ///  new[] { 1, 2, 3 },
    ///  new[] { 4, 5, 6 },
    ///  new[] { 7, 8, 9 }
    ///  })
    ///  ->
    ///  [[7, 4, 1],
    ///  [8, 5, 2],
    ///  [9, 6, 3]]
    /// </summary>
    public static void RotateMatrix90Clockwise(int[][] matrix)
    {
        var len = matrix?.Length ?? throw new ArgumentNullException(nameof(matrix));
        if (!matrix.All(x => x.Length == len))
        {
            throw new ArgumentException("Must be a square", nameof(matrix));
        }

        for (var i = 0; i < len; ++i)
        {
            for (var j = i + 1; j < len; ++j)
            {
                var tmp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = tmp;
            }
        }

        foreach(var row in matrix)
        {
            Array.Reverse(row);
        }
    }
}

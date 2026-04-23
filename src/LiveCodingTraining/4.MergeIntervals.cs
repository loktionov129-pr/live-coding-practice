namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// Объединяет пересекающиеся интервалы в непересекающийся набор.
    /// Интервал представлен как [start, end].
    /// Пример: MergeIntervals
    /// (
    ///     new[]
    ///     {
    ///         new[] { 1, 3 },
    ///         new[] { 2, 6 },
    ///         new[] { 8, 10 },
    ///         new[] { 15, 18 }
    ///     }
    /// )
    /// ->
    /// [[1, 6], [8, 10], [15, 18]]
    /// </summary>
    public static int[][] MergeIntervals(int[][] intervals)
    {
        if (intervals.Length <= 1) return intervals;

        var sorted = intervals.OrderBy(i => i[0]).ToArray();
        var result = new List<int[]>();
        var current = sorted[0];
        result.Add(current);

        foreach (var next in sorted.Skip(1))
        {
            if (next[0] <= current[1])
            {
                current[1] = Math.Max(current[1], next[1]);
            }
            else
            {
                current = next;
                result.Add(current);
            }
        }

        return result.ToArray();
    }
}

namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// Дан отсортированный по возрастанию массив целых чисел numbers.
    /// Необходимо найти два числа, сумма которых равна заданному значению target.
    /// Вернуть индексы этих чисел.
    /// Существует ровно одно решение. Ограничение сложности: O(n).
    /// Пример: TwoSum(new int[] { 2, 7, 11, 15 }, 9) -> [0, 1]
    /// </summary>
    public static int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];

            if (sum == target)
            {
                return [left, right];
            }

            if (sum > target)
            {
                --right;
            }
            else
            {
                ++left;
            }
        }

        throw new ArgumentException(null, nameof(target));
    }

    // O(N*N)
    public static int[] TwoSum2(int[] numbers, int target)
    {
        for (var i = 0; i < numbers.Length; ++i)
        {
            for (var j = 0; j < numbers.Length; ++j)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return [i, j];
                }
            }
        }

        throw new ArgumentException(null, nameof(target));
    }
}

namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// Определить, является ли число совершенным квадратом.
    /// Ограничение сложности: O(log n).
    /// Пример: IsPerfectSquare(16) -> true, IsPerfectSquare(14) -> false
    /// </summary>
    public static bool IsPerfectSquare(int num)
    {
        if (num <= 0)
        {
            return false;
        }

        if (num == 1)
        {
            return true;
        }

        long left = 2;
        long right = num / 2;

        while (left <= right)
        {
            long target = left + (right - left) / 2;
            long doubled = target * target;

            if (doubled == num)
            {
                return true;
            }

            if (doubled > num)
            {
                right = target - 1;
            }
            else
            {
                left = target + 1;
            }
        }

        return false;
    }
}

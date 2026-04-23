namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// На вход поступает массив целых чисел.
    /// Необходимо найти индекс, при котором сумма чисел слева и справа равны.
    /// Если массив пустой или такого индекса нет, вернуть -1.
    /// Пример: FindEvenIndex(new int[] { 1, 2, 3, 4, 3, 2, 1 }) -> 3
    /// </summary>
    public static int FindEvenIndex(int[] arr)
    {
        var arrLength = arr?.Length - 1 ?? throw new ArgumentNullException(nameof(arr));

        if (arrLength == 0)
        {
            return 0;
        }

        for (var i = 1; i < arrLength; ++i)
        {
            var leftSum = arr!.Take(i).Sum();
            var rightSum = arr!.Skip(1 + i).Sum();

            if (leftSum == rightSum)
            {
                return i;
            }
        }


        return -1;
    }
}

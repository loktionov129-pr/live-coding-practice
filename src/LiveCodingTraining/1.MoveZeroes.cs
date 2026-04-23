namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// Метод принимает массив целых чисел. Необходимо переместить нули в конец массива,
    /// сохранив относительный порядок остальных элементов.
    /// Пример: MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }) -> [1, 2, 1, 1, 3, 1, 0, 0, 0, 0]
    /// </summary>
    public static int[] MoveZeroes(int[] arr)
    {
        var arrLength = arr?.Length ?? throw new ArgumentNullException(nameof(arr));
        var result = new int[arrLength];
        var resultIdx = 0;

        // Копируем все элементы кроме нулей
        for (var i = 0; i < arrLength; ++i)
        {
            if (arr[i] != 0)
            {
                result[resultIdx] = arr[i];
                ++resultIdx;
            }
        }

        // дозаполняем нулями
        for (; resultIdx < arrLength; ++resultIdx)
        {
            result[resultIdx] = 0;
        }

        return result;
    }
}

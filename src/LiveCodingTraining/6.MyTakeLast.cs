namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// Реализовать метод расширения для Enumerable - TakeLast.
    /// Метод должен вернуть n последних элементов перечисления.
    /// Пример: new[] { 1, 2, 3, 4, 5 }.MyTakeLast(3) -> [3, 4, 5]
    /// </summary>
    public static IEnumerable<TSource> MyTakeLast<TSource>(this IEnumerable<TSource> source, int count)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (count <= 0)
        {
            yield break;
        }

        if (source is ICollection<TSource> collection)
        {            
            int i = 0;
            int skipCount = collection.Count - count;
            foreach (var item in source)
            {
                if (i >= skipCount)
                {
                    yield return item;
                }
                i++;
            }
            yield break;
        }

        TSource[] buffer = new TSource[count];
        int processed = 0;
        int index = 0;

        foreach (var item in source)
        {
            buffer[index] = item;
            index = (index + 1) % count;
            processed++;
        }

        int loadedCount = Math.Min(processed, count);
        int start = processed > count ? index : 0;

        for (int i = 0; i < loadedCount; i++)
        {
            yield return buffer[(start + i) % count];
        }
    }
}
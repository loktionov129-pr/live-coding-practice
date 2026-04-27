namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// Реализовать метод расширения для Enumerable - SkipLast.
    /// Метод должен вернуть IEnumerable без n последних элементов.
    /// Пример: new[] { 1, 2, 3, 4, 5 }.MySkipLast(2) -> [1, 2, 3]
    /// </summary>
    public static IEnumerable<TSource> MySkipLast<TSource>(this IEnumerable<TSource> source, int count)
    {
        if (source == null)
        {
            throw new ArgumentNullException(nameof(source));
        }

        if (count <= 0)
        {
            foreach (var item in source) yield return item;
            yield break;
        }

        if (source is ICollection<TSource> collection)
        {
            var countToReturn = collection.Count - count;
            if (countToReturn <= 0)
            {
                yield break;
            }
            
            int i = 0;
            foreach (var item in source)
            {
                if (i >= count)
                {
                    yield break;
                }
                yield return item;
                i++;
            }
        }

        var buffer = new TSource[count];
        var counter = 0;
        var index = 0;

        foreach (var item in source)
        {
            if (counter == count)
            {
                yield return buffer[index];
            }
            else
            {
                counter++;
            }

            buffer[index] = item;
            index = (index + 1) % count;
        }
    }
}

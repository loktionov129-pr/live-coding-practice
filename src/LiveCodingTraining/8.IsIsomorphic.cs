namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// Проверяет, являются ли две строки изоморфными.
    /// Пример: IsIsomorphic("egg", "add") -> true
    ///          IsIsomorphic("foo", "bar") -> false
    /// </summary>
    public static bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var d = new Dictionary<char, char>();

        for (var i = 0; i < s.Length; ++i)
        {
            var c = s[i];
            var x = t[i];
            var b1 = d.TryGetValue(c, out var v) && v != x;
            var b2 = d.ContainsValue(x) && d.First(a => a.Value == x).Key != c;
            if (b1 || b2)
            {
                return false;
            }

            d[c] = x;
        }

        return true;
    }
}

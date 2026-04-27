namespace LiveCodingTraining.TenBest;

public static partial class LiveCodingPractice
{
    /// <summary>
    /// Вычисляет значение выражения в постфиксной нотации.
    /// Поддерживаемые операторы: +, -, *, /.
    /// Операнды разделены пробелами.
    /// Пример: EvaluatePostfixExpression("2 1 + 3 *") -> 9
    /// </summary>
    public static int EvaluatePostfixExpression(string expression)
    {
        var tokens = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var stack = new Stack<int>();

        foreach (var token in tokens)
        {
            if (int.TryParse(token, out var num))
            {
                stack.Push(num);
                continue;
            }

            var right = stack.Pop();
            var left = stack.Pop();
            stack.Push(token switch
            {
               "*" => left * right,
               "/" => left / right,
               "+" => left + right,
               "-" => left - right,
               _ => throw new InvalidOperationException($"'{token}' - invalid operation"),
            });
        }

        return stack.Pop();
    }
}

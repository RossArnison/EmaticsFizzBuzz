using EmaticsFizzBuzz.Worker.Extensions;

namespace EmaticsFizzBuzz.Worker.Service;

public class FizzBuzzService : Interface.IFizzBuzzService
{
    public Task<IEnumerable<string>> CreateSequenceAsync(int start, int end, CancellationToken token)
    {
        return Task.Run(() => CreateSequence(start, end), token);
    }

    public IEnumerable<string> CreateSequence(int start, int end)
    {
        ValidateInput(start, end);

        var sequence = CreateRange(start, end).Select(GetFizzBuzzValue);
        return sequence;
    }

    private static void ValidateInput(int start, int end)
    {
        if (start > end) 
            throw new ArgumentException($"The start parameter must be lower than end{Environment.NewLine}[start:{start}|end:{end}]");
    }

    private static IEnumerable<int> CreateRange(int start, int end)
    {
        var count = end - start + 1;
        return Enumerable.Range(start, count);
    }

    private static string GetFizzBuzzValue(int value)
    {
        if (value.IsMultipleOf(15)) 
            return "FizzBuzz";
        
        if (value.IsMultipleOf(3)) 
            return "Fizz";

        if (value.IsMultipleOf(5))
            return "Buzz";

        return value.ToString();
    }
}
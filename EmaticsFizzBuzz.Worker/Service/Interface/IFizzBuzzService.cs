namespace EmaticsFizzBuzz.Worker.Service.Interface;

public interface IFizzBuzzService
{
    /// <summary>
    /// Creates a FizzBuzz sequence
    /// </summary>
    /// <param name="start">The first item in the sequence</param>
    /// <param name="end">The last item in the sequence</param>
    /// <param name="token">Cancellation Token</param>
    /// <returns>a list of strings containing the fizz buzz sequence</returns>
    Task<IEnumerable<string>> CreateSequenceAsync(int start, int end, CancellationToken token);
    
    
    /// <summary>
    /// Creates a FizzBuzz sequence
    /// </summary>
    /// <param name="start">The first item in the sequence</param>
    /// <param name="end">The last item in the sequence</param>
    /// <returns>a list of strings containing the fizz buzz sequence</returns>
    IEnumerable<string> CreateSequence(int start, int end);
}
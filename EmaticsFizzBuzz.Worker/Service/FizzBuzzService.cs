namespace EmaticsFizzBuzz.Worker.Service;

public class FizzBuzzService : Interface.IFizzBuzzService
{
    public Task<IEnumerable<string>> CreateSequenceAsync(int start, int end, CancellationToken token)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<string> CreateSequence(int start, int end)
    {
        throw new NotImplementedException();
    }

    private void ValidateInput()
    {
        throw new NotImplementedException();
    }

    private IEnumerable<int> CreateRange(int start, int end)
    {
        throw new NotImplementedException();
    }

    private string GetFizzBuzzValue(int item)
    {
        throw new NotImplementedException();
    }
}
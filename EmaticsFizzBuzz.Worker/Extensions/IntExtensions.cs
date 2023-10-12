namespace EmaticsFizzBuzz.Worker.Extensions;

public static class IntExtensions
{
    /// <summary>
    /// Checks if an int is a multiple
    /// </summary>
    /// <param name="value">Value to check</param>
    /// <param name="multiple">Multiple to check against</param>
    /// <returns>True if the value is a multiple</returns>
    public static bool IsMultipleOf(this int value, int multiple) => value % multiple == 0;
}
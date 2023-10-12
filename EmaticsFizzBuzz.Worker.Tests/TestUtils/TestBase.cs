using System.Reflection;

namespace EmaticsFizzBuzz.Worker.Tests.TestUtils;

internal abstract class TestBase
{
    /// <summary> Binding Flags to cover all method types </summary>
    private const BindingFlags DefaultBindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;

    /// <summary>
    /// Invoke any method
    /// </summary>
    /// <param name="target">Object with the method on</param>
    /// <param name="methodName">Name of the method</param>
    /// <param name="methodParams">Parameters required for the method</param>
    /// <typeparam name="TResult">Return type of the method</typeparam>
    /// <returns>The invoked result of the method</returns>
    /// <exception cref="ArgumentException">method name must exist on the target</exception>
    protected static TResult InvokeMethod<TResult>(object target, string methodName, params object[] methodParams)
    {
        var targetType = target.GetType();
        
        var method = targetType.GetMethod(methodName, DefaultBindingFlags)
                     ?? throw new ArgumentException("The given method name does not exist on the target");

        return (TResult)method.Invoke(target, methodParams);
    }
}
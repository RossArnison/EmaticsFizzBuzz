using EmaticsFizzBuzz.Worker.Service;
using EmaticsFizzBuzz.Worker.Service.Interface;

namespace EmaticsFizzBuzz.Worker.Tests.Service.FizzBuzzServiceTests.Base;

internal abstract class BaseFizzBuzzServiceTests
{
    protected IFizzBuzzService _service;
    
    [SetUp]
    public virtual void Initialise()
    {
        _service = new FizzBuzzService();
    }
}
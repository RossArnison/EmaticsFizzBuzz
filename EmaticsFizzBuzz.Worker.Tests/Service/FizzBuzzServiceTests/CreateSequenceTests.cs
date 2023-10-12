using NUnit.Framework;

namespace EmaticsFizzBuzz.Worker.Tests.Service.FizzBuzzServiceTests;

[TestFixture]
internal class CreateSequenceTests : Base.BaseFizzBuzzServiceTests
{
    [Test]
    public void ValidateInput_WhenEndIsLessThanStart_ThrowArgumentException()
    {
        // arrange
        const int start = 10;
        const int end = 5;

        // act
        var action = () => _service.CreateSequence(start, end);

        // assert
        Assert.That(action, Throws.TypeOf<ArgumentException>());
    }
    
    [Test]
    public void ValidateInput_WhenEndIsGreaterThanStart_NoExceptionThrown()
    {
        // arrange
        const int start = 5;
        const int end = 10;

        // act
        var action = () => _service.CreateSequence(start, end);

        // assert
        Assert.That(action, Throws.Nothing);
    }

    [Test]
    public void GetRange_WhenRangeGiven_ReturnThatAmountOfItems()
    {
        // arrange
        const int start = 1;
        const int end = 10;

        // act
        var sequence = _service.CreateSequence(start, end);

        // assert
        Assert.That(sequence.Count(), Is.EqualTo(10));
    }

    [Test]
    public void GetFizzBuzzValue_WhenRangeIncludesMultipleOf3_ReturnFizzInstead()
    {
        // arrange
        const int start = 1;
        const int end = 20;

        // act
        var sequence = _service.CreateSequence(start, end);

        // assert
        Assert.That(sequence.ElementAt(2), Is.EqualTo("Fizz"));
    }

    [Test]
    public void GetFizzBuzzValue_WhenRangeIncludesMultipleOf5_ReturnBuzzInstead()
    {
        // arrange
        const int start = 1;
        const int end = 20;

        // act
        var sequence = _service.CreateSequence(start, end);

        // assert
        Assert.That(sequence.ElementAt(4), Is.EqualTo("Buzz"));
    }

    [Test]
    public void GetFizzBuzzValue_WhenRangeIncludesMultipleOf3And5_ReturnFizzBuzzInstead()
    {
        // arrange
        const int start = 1;
        const int end = 20;

        // act
        var sequence = _service.CreateSequence(start, end);

        // assert
        Assert.That(sequence.ElementAt(14), Is.EqualTo("FizzBuzz"));
    }
}
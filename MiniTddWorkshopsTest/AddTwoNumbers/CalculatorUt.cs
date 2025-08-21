using MiniTddWorkshops.AddTwoNumbers;

namespace MiniTddWorkshopsTest.AddTwoNumbers;

[TestFixture]
public class CalculatorUt
{
    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        Assert.That(Calculator.Add(2, 3), Is.EqualTo(5));
    }

    [Test]
    public void Add_WithZero_ReturnsOtherNumber()
    {
        Assert.That(Calculator.Add(0, 7), Is.EqualTo(7));
    }
}
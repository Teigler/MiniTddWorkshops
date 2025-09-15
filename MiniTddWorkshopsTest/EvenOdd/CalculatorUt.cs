
using MiniTddWorkshops.EvenOdd;

namespace MiniTddWorkshopsTest.EvenOdd;

[TestFixture]
public class CalculatorUt
{
    [TestCase(2)]
    [TestCase(4)]
    [TestCase(6)]
    public void IsEvenTest(int number)
    {
        var calculator = CreateCalculator();
        Assert.IsTrue(calculator.IsEven(number));
    }

    [TestCase(1)]
    [TestCase(3)]
    [TestCase(5)]
    public void IsOddTest(int number)
    {
        var calculator = CreateCalculator();
        Assert.IsFalse(calculator.IsEven(number));
    }

    private static Calculator CreateCalculator()
    {
        var calculator = new Calculator();
        return calculator;
    }
}
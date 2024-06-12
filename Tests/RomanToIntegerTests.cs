using Easy;

namespace Tests;

[TestFixture]
public class RomanToIntegerTests
{
    [Test]
    public void RomanToInt_WhenMaxOfConcatSymbols_Return3()
    {
        const string input = "III";
        var romanToInteger = CreateRomanToInteger();

        var result = romanToInteger.RomanToInt(input);

        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void RomanToInt_WhenDifferentPlaceNumber_Return58()
    {
        const string input = "LVIII";
        var romanToInteger = CreateRomanToInteger();

        var result = romanToInteger.RomanToInt(input);

        Assert.That(result, Is.EqualTo(58));
    }

    [Test]
    public void RomanToInt_WhenSubstactionSymbol_Return1994()
    {
        const string input = "MCMXCIV";
        var romanToInteger = CreateRomanToInteger();

        var result = romanToInteger.RomanToInt(input);

        Assert.That(result, Is.EqualTo(1994));
    }

    private static RomanToInteger CreateRomanToInteger() => new ();
}

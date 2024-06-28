using Easy;

namespace Tests;

[TestFixture]
public class ValidParenthesesTest
{
    [Test]
    public void IsValid_WhenOnlyOnePair_ReturnTrue()
    {
        const string input = "()";
        var validParentheses = CreateValidParentheses();

        var result = validParentheses.IsValid(input);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValid_WhenEmptyString_ReturnFalse()
    {
        var validParentheses = CreateValidParentheses();

        var result = validParentheses.IsValid(string.Empty);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValid_WhenOddSymbolsCount_ReturnFalse()
    {
        const string input = "(){";
        var validParentheses = CreateValidParentheses();

        var result = validParentheses.IsValid(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValid_WhenInvalidSinglePair_ReturnFalse()
    {
        const string input = "(}";
        var validParentheses = CreateValidParentheses();

        var result = validParentheses.IsValid(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValid_WhenNestedLevel1_ReturnTrue()
    {
        const string input = "([])";
        var validParentheses = CreateValidParentheses();

        var result = validParentheses.IsValid(input);
        
        Assert.That(result, Is.True);
    }

    [Test]
    public void IsValid_WhenInvalidSequence_ReturnFalse()
    {
        const string input = "([)]";
        var validParentheses = CreateValidParentheses();

        var result = validParentheses.IsValid(input);
        
        Assert.That(result, Is.False);
    }

    [Test]
    public void IsValid_WhenStartWitnCloseSymbol_ReturnFalse()
    {
        const string input = "][";
        var validParentheses = CreateValidParentheses();

        var result = validParentheses.IsValid(input);
        
        Assert.That(result, Is.False);
    }
    
    private static ValidParentheses CreateValidParentheses() => new();
}
using Easy;

namespace Tests;

[TestFixture]
public class LongestCommonPrefixTests
{
    [Test]
    public void FindLongestCommonPrefix_WhenStartOfString_ReturnFL()
    {
        var input = new[] { "flower","flow","flight" };
        var longestCommonPrefix = CreateLongestCommonPrefix();

        var result = longestCommonPrefix.FindLongestCommonPrefix(input);

        Assert.That(result, Is.EqualTo("fl"));
    }

    [Test]
    public void FindLongestCommonPrefix_WhenEmptyInputArray_ReturnEmptyString()
    {
        var longestCommonPrefix = CreateLongestCommonPrefix();

        var result = longestCommonPrefix.FindLongestCommonPrefix([]);

        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void FindLongestCommonPrefix_WhenOneInputString_ReturnInputString()
    {
        var input = new[]{"inputString"};
        var longestCommonPrefix = CreateLongestCommonPrefix();

        var result = longestCommonPrefix.FindLongestCommonPrefix(input);

        Assert.That(result, Is.EqualTo(input[0]));
    }

    [Test]
    public void FindLongestCommonPrefix_WhenOneStartDifferent_ReturnEmptyString()
    {
        var input = new[] { "reflower","flow","flight" };
        var longestCommonPrefix = CreateLongestCommonPrefix();

        var result = longestCommonPrefix.FindLongestCommonPrefix(input);
        
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void FindLongestCommonPrefix_WhenMultipleEmptyStrings_ReturnEmptyString()
    {
        var input = new[] { "", "" };
        var longestCommonPrefix = CreateLongestCommonPrefix();

        var result = longestCommonPrefix.FindLongestCommonPrefix(input);
        
        Assert.That(result, Is.EqualTo(string.Empty));
    }

    [Test]
    public void FindLongestCommonPrefix_WhenABandA_ReturnA()
    {
        var input = new[] { "ab", "a" };
        var longestCommonPrefix = CreateLongestCommonPrefix();

        var result = longestCommonPrefix.FindLongestCommonPrefix(input);
        
        Assert.That(result, Is.EqualTo("a"));
    }
    
    private static LongestCommonPrefix CreateLongestCommonPrefix() => new();
}

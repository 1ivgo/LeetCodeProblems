using Easy;

namespace Tests;

[TestFixture]
public class PulindromeNumberTests
{
    [Test]
    public void IsPalindrome_WhenCase1_ReturnTrue()
    {
        const int input = 121;
        var palindromeNumber = CreatePulindromeNumber();

        var result = palindromeNumber.IsPalindrome(input);

        Assert.That(result, Is.True);
    }

    [Test]
    public void IsPalindrome_WhenNumberLessThan10_ReturnTrue()
    {
        const int input = 5;
        var palindromeNumber = CreatePulindromeNumber();

        var result = palindromeNumber.IsPalindrome(input);

        Assert.That(result, Is.True);
    }

    private static PulindromeNumber CreatePulindromeNumber() => new();
}
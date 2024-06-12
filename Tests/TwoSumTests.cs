using Easy;
using NUnit.Framework.Internal;

namespace Tests;

[TestFixture]
public class TwoSumTests
{
    [Test]
    public void Solve_WhenTwoNumbersInInputArray_ReturnIndexes()
    {
        var nums = new int[] { 2, 7, 11, 15 };
        const int target = 9;
        var answer = new int[] {0, 1};
        var twoSum = CreateTwoSum();

        var result = twoSum.Solve(nums, target);

        Assert.That(result, Is.EqualTo(answer));
    }

    [Test]
    public void Solve_WhenTwoEqualNumberInInput_ReturnIndexes()
    {
        var nums = new int[] { 2, 5, 5, 11 };
        const int target = 10;
        var answer = new int[] {1, 2};
        var twoSum = CreateTwoSum();

        var result = twoSum.Solve(nums, target);

        Assert.That(result, Is.EqualTo(answer));
    }

    [Test]
    public void Solve_WhenResultZero_ReturnIndexes()
    {
        var nums = new int[] { 0, 4, 3, 0 };
        const int target = 0;
        var answer = new int[] {0, 3};
        var twoSum = CreateTwoSum();

        var result = twoSum.Solve(nums, target);

        Assert.That(result, Is.EqualTo(answer));
    }

    [Test]
    public void Solve_WhenSimilarNumbers_ReturnIndexes()
    {
        var nums = new int[] {1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1};
        const int target = 11;
        var answer = new int[] {5, 11};
        var twoSum = CreateTwoSum();

        var result = twoSum.Solve(nums, target);

        Assert.That(result, Is.EqualTo(answer));
    }

    private static TwoSum CreateTwoSum() => new();
}
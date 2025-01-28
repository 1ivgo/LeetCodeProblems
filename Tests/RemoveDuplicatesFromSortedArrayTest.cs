using Easy;

namespace Tests;

[TestFixture]
[TestOf(typeof(RemoveDuplicatesFromSortedArray))]
public class RemoveDuplicatesFromSortedArrayTest
{
    [Test]
    public void RemoveDuplicates_DuplicatedRemoved()
    {
        var removeDuplicatesFromSortedArray = CreateRemoveDuplicatesFromSortedArray();
        var inputArray = new[] {1, 1, 2};

        var result = removeDuplicatesFromSortedArray.RemoveDuplicates(inputArray);
        
        var answer = new[] { 1, 2 };
        Assert.That(result, Is.EqualTo(answer.Length));
        for (var i = 0; i < answer.Length; i++) 
            Assert.That(answer[i], Is.EqualTo(inputArray[i]));
    }

    [Test]
    public void RemoveDuplicated_WhenSecond_DuplicatesRemoved()
    {
        var removeDuplicatesFromSortedArray = CreateRemoveDuplicatesFromSortedArray();
        var inputArray = new[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

        var result = removeDuplicatesFromSortedArray.RemoveDuplicates(inputArray);

        var answer = new[] { 0, 1, 2, 3, 4 };
        Assert.That(result, Is.EqualTo(answer.Length));
        for (var i = 0; i < answer.Length; i++) 
            Assert.That(answer[i], Is.EqualTo(inputArray[i]));
    }
    
    private static RemoveDuplicatesFromSortedArray CreateRemoveDuplicatesFromSortedArray() => new();
}
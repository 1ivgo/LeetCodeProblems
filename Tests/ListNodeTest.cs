using Common;

namespace Tests;

[TestFixture]
public class ListNodeTest
{
    [Test]
    public void ToEnumerable_WhenTwoElements_ReturnTwoElements()
    {
        const int firstValue = 99;
        const int secondValue = -767;
        var listNode = CreateListNode(firstValue, next: CreateListNode(secondValue));

        var result = listNode.ToEnumerable();

        CollectionAssert.AreEqual(result, new[] { firstValue, secondValue });
    }

    [Test]
    public void ToEnumerable_WhenNextIsNull_ReturnOneValue()
    {
        const int firstValue = 787;
        var listNode = CreateListNode(firstValue);

        var result = listNode.ToEnumerable();

        CollectionAssert.AreEqual(result, new[] { firstValue });
    }
    
    private static ListNode CreateListNode(int? value = null,
        ListNode? next = null) => new(value ?? 0, next);
}
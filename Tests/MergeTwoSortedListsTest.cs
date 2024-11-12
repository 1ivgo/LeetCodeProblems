using Common;
using Easy;

namespace Tests;

[TestFixture]
public class MergeTwoSortedListsTest
{
    [Test]
    public void MergeTwoLists_WhenIntersection_ReturnMergedList()
    {
        var mergeTwoSortedLists = CreateMergeTwoSortedLists();
        var node1 = CreateListNode(1, next: CreateListNode(2, next: CreateListNode(4)));
        var node2 = CreateListNode(1, next: CreateListNode(3, next: CreateListNode(4)));

        var result = mergeTwoSortedLists.MergeTwoLists(node1, node2);

        CollectionAssert.AreEqual(new[] { 1, 1, 2, 3, 4, 4 }, result?.ToEnumerable());
    }

    [Test]
    public void MergeTwoLists_WhenAllNull_ReturnNull()
    {
        var mergeTwoSortedLists = CreateMergeTwoSortedLists();

        var result = mergeTwoSortedLists.MergeTwoLists(null, null);
        
        Assert.That(result, Is.Null);
    }

    [Test]
    public void MergeTwoLists_WhenFirstNull_ReturnSecond()
    {
        const int secondValue = 4;
        var mergeTwoSortedLists = CreateMergeTwoSortedLists();

        var result = mergeTwoSortedLists.MergeTwoLists(null, new ListNode(secondValue));

        Assert.Multiple(() =>
        {
            Assert.That(result!.Value, Is.EqualTo(secondValue));
            Assert.That(result.Next, Is.Null);            
        });
    }
    
    private static MergeTwoSortedLists CreateMergeTwoSortedLists() => new();

    private static ListNode CreateListNode(int value, ListNode? next = null) => new(value, next);
}
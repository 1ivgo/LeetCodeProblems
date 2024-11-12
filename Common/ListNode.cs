namespace Common;

public sealed class ListNode
{
    public int Value { get; }
    public ListNode? Next { get; }
        
    // ReSharper disable ConvertToPrimaryConstructor
    public ListNode(int value = 0, ListNode? next = null) 
    // ReSharper restore ConvertToPrimaryConstructor
    {
        Value = value;
        Next = next;
    }
    
    public IEnumerable<int> ToEnumerable()
    {
        yield return Value;
        if(Next == null)
            yield break;
        
        foreach (var value in Next.ToEnumerable())
            yield return value;
    }
}

namespace Easy;

internal sealed class ValidParentheses
{
    private readonly Dictionary<char, char> _closePair = new()
    {
        { ')', '(' }, { ']', '[' }, { '}', '{' }
    };
    
    internal bool IsValid(string s)
    {
        var stack = new Stack<char>();
        
        foreach (var symbol in s)
        {
            switch (symbol)
            {
                case '(' or '[' or '{':
                    stack.Push(symbol);
                    continue;
                case ')' or ']' or '}' when stack.Count == 0 || stack.Pop() != _closePair[symbol]:
                    return false;
                case ')' or ']' or '}':
                    continue;
                default:
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
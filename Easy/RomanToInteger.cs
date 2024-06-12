namespace Easy;

internal sealed class RomanToInteger
{
    internal int RomanToInt(string s) 
    {
        var result = 0;

        foreach(var symbol in s)
        {
            result += RomanSymbolToInteger(symbol);
        }
        
        return result;

        static int RomanSymbolToInteger(char symbol)
        {
            return symbol switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new NotSupportedException()
            };
        }
    }
}

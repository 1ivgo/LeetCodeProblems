namespace Easy;

internal sealed class RomanToInteger
{
    internal int RomanToInt(string s) 
    {
        var result = 0;
        var toDiff = 0;

        for(var i = 0; i < s.Length; i++)
        {
            var current = RomanSymbolToInteger(s[i]);
            if(i < s.Length - 1 && current < RomanSymbolToInteger(s[i + 1]))
            {
                toDiff += current;
                continue;
            }

            result += current -= toDiff;
            toDiff = 0;
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

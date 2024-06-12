namespace Easy;

// 9
internal sealed class PulindromeNumber
{
    public bool IsPalindrome(int x)
     {
        if(x < 0)
            return false;
        if(x / 10 == 0)
            return true;
        
        var reverseValue = 0;
        var temp = x;
        while(temp / 10 != 0)
        {
            reverseValue += temp % 10;
            reverseValue *= 10;
            temp /= 10;
        }
        reverseValue += temp;

        return x == reverseValue;
    }
}
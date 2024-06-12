namespace Easy;

// 1
internal sealed class TwoSum 
{
    public int[] Solve(int[] nums, int target) 
    {
        var seenNumbers = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++)
        {
            var difference = target - nums[i];
            if(seenNumbers.ContainsKey(difference))
                return [seenNumbers[difference], i];
            
            if(!seenNumbers.ContainsKey(nums[i]))
                seenNumbers.Add(nums[i], i);
        }

        throw new InvalidOperationException();
    }
}

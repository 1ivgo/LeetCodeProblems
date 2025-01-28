namespace Easy;

internal sealed class RemoveDuplicatesFromSortedArray
{
    internal int RemoveDuplicates(int[] nums)
    {
        var count = 1;
        var skip = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
                skip++;
            else
            {
                nums[i - skip] = nums[i];
                count++;
            }
        }

        return count;
    }
}
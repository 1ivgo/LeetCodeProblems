using System.Text;

namespace Easy;

internal sealed class LongestCommonPrefix
{
	internal string FindLongestCommonPrefix(string[] strs)
	{
		if(strs.Length == 0)
			return string.Empty;
		
		var minLength = strs[0].Length;
		foreach (var str in strs)
		{
			minLength = Math.Min(str.Length, minLength);
		}	
		
		for (int i = 0; i < minLength; i++)
		{
			var symbol = strs[0][i];
			for (int j = 0; j < strs.Length; j++)
			{
				if(strs[j][i] != symbol)
					return strs[0][..i];
			}
		}
			
		return strs[0][..minLength]; 
	}
	
	// internal string FindLongestCommonPrefix(string[] strs)
	// {
	//     switch (strs.Length)
	//     {
	//         case 0:
	//             return string.Empty;
	//         case 1:
	//             return strs[0];
	//     }
	//
	//     var foundPrefixes = new SortedList<int, string>();
	//
	//     var first = strs[0];
	//     var left = 0;
	//     var right = 0;
	//     for(; left < first.Length - 1; left++)
	//     {
	//         while(strs.All(str => str.Contains(first.Substring(left, right - left + 1))))
	//         {
	//             right++;
	//         }
	//
	//         var result = first.Substring(left, right - left);
	//         if(!string.IsNullOrEmpty(result))
	//             foundPrefixes.TryAdd(result.Length, result);
	//     }
	//
	//     return foundPrefixes.LastOrDefault().Value ?? string.Empty;
	// }
}

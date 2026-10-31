using System;
using System.Collections.Generic;

public class Solution {
	public int LengthOfLongestSubstring(string s) {
		HashSet<char> characters = new HashSet<char>();
		int startIndex = 0;
		int longestLength = 0;

		for (int currentIndex = 0; currentIndex < s.Length; currentIndex++) {
			while (characters.Contains(s[currentIndex])) {
				characters.Remove(s[startIndex]);
				startIndex++;
			}

			characters.Add(s[currentIndex]);

			int currentLength = currentIndex - startIndex + 1;
			if (currentLength > longestLength) {
				longestLength = currentLength;
			}
		}

		return longestLength;
	}
}

public class Program {
	public static void Main() {
		var solution = new Solution();
		Console.WriteLine(solution.LengthOfLongestSubstring("abcabcbb"));
		Console.WriteLine(solution.LengthOfLongestSubstring("bbbbb"));
		Console.WriteLine(solution.LengthOfLongestSubstring("pwwkew"));
	}
}

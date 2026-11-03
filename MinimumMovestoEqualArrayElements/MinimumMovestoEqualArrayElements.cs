using System;

public class Solution {
    public int MinMoves(int[] nums) {
        int minimum = nums[0];

        foreach (int number in nums) {
            minimum = Math.Min(minimum, number);
        }

        // Incrementing n - 1 elements is equivalent to decrementing one.
        long moves = 0;
        foreach (int number in nums) {
            moves += (long)number - minimum;
        }

        return (int)moves;
    }
}

public class Program {
    public static void Main() {
        var solution = new Solution();
        Console.WriteLine(solution.MinMoves(new[] { 1, 2, 3 }));
        Console.WriteLine(solution.MinMoves(new[] { 1, 1, 1 }));
    }
}

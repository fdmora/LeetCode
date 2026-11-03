using System;

public class Solution {
    public int MinMoves(int[] nums) {
        int maximum = nums[0];
        foreach (int number in nums) {
            maximum = Math.Max(maximum, number);
        }

        int moves = 0;
        foreach (int number in nums) {
            moves += maximum - number;
        }

        return moves;
    }
}

public class Program {
    public static void Main() {
        var solution = new Solution();
        Console.WriteLine(solution.MinMoves(new[] { 2, 1, 3 }));
        Console.WriteLine(solution.MinMoves(new[] { 4, 4, 5 }));
    }
}

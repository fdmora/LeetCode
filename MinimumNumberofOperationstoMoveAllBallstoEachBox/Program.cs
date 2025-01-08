using System;

public class Solution {
    public int[] MinOperations(string boxes) {
        int n = boxes.Length;
        int[] answer = new int[n];
        
        // First pass: from left to right
        int balls = 0; // Number of balls encountered so far
        int operations = 0; // Total operations needed to move balls to the current box
        
        for (int i = 0; i < n; i++) {
            answer[i] += operations; // Add current operations to answer
            if (boxes[i] == '1') {
                balls++; // Count the ball in the current box
            }
            operations += balls; // Update operations for the next box
        }
        
        // Second pass: from right to left
        balls = 0; // Reset balls count
        operations = 0; // Reset operations count
        
        for (int i = n - 1; i >= 0; i--) {
            answer[i] += operations; // Add current operations to answer
            if (boxes[i] == '1') {
                balls++; // Count the ball in the current box
            }
            operations += balls; // Update operations for the next box
        }
        
        return answer;
    }
}

// Example usage
public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        string boxes1 = "110";
        int[] result1 = solution.MinOperations(boxes1);
        Console.WriteLine(string.Join(", ", result1)); // Output: [1, 1, 3]
        
        string boxes2 = "001011";
        int[] result2 = solution.MinOperations(boxes2);
        Console.WriteLine(string.Join(", ", result2)); // Output: [11, 8, 5, 4, 3, 4]
    }
}
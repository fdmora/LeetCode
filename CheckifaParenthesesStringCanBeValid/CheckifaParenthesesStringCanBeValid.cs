public class Solution {
    public bool CanBeValid(string s, string locked) {
         int n = s.Length;
        
        // Check if length is odd, which can never be valid
        if (n % 2 != 0) return false;
        
        // First pass: Checking from left to right
        int openCount = 0;  // Counts open parentheses we encounter
        int closeCount = 0; // Counts close parentheses we encounter
        
        // Traverse from left to right
        for (int i = 0; i < n; i++) {
            if (locked[i] == '1') {
                if (s[i] == '(') openCount++;
                else if (s[i] == ')') closeCount++;
            } else {
                // unlocked character: we can treat it as '(' or ')'
                // Try to balance them as much as possible
                openCount++;
            }
            
            // If we have more close parentheses than open ones, it's invalid
            if (closeCount > openCount) {
                return false;
            }
        }
        
        // Second pass: Check from right to left
        openCount = 0;
        closeCount = 0;
        
        for (int i = n - 1; i >= 0; i--) {
            if (locked[i] == '1') {
                if (s[i] == '(') openCount++;
                else if (s[i] == ')') closeCount++;
            } else {
                closeCount++;
            }
            
            // If we have more open parentheses than close ones, it's invalid
            if (openCount > closeCount) {
                return false;
            }
        }
        
        return true;
    }
}
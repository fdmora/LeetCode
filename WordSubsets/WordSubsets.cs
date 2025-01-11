public class Solution {
    public IList<string> WordSubsets(string[] words1, string[] words2) {
                // Step 1: Create a frequency map for the characters in words2
        Dictionary<char, int> maxFreq = new Dictionary<char, int>();
        
        foreach (var word in words2) {
            Dictionary<char, int> wordFreq = new Dictionary<char, int>();
            foreach (var c in word) {
                if (wordFreq.ContainsKey(c)) {
                    wordFreq[c]++;
                } else {
                    wordFreq[c] = 1;
                }
            }
            
            // Update the maxFreq dictionary to store the maximum count of each character
            foreach (var kvp in wordFreq) {
                if (maxFreq.ContainsKey(kvp.Key)) {
                    maxFreq[kvp.Key] = Math.Max(maxFreq[kvp.Key], kvp.Value);
                } else {
                    maxFreq[kvp.Key] = kvp.Value;
                }
            }
        }
        
        // Step 2: Check each word in words1 to see if it satisfies the requirements
        List<string> result = new List<string>();
        
        foreach (var word in words1) {
            Dictionary<char, int> wordFreq = new Dictionary<char, int>();
            foreach (var c in word) {
                if (wordFreq.ContainsKey(c)) {
                    wordFreq[c]++;
                } else {
                    wordFreq[c] = 1;
                }
            }
            
            // Check if the word satisfies all character frequency requirements in maxFreq
            bool isValid = true;
            foreach (var kvp in maxFreq) {
                if (!wordFreq.ContainsKey(kvp.Key) || wordFreq[kvp.Key] < kvp.Value) {
                    isValid = false;
                    break;
                }
            }
            
            // If the word is valid, add it to the result list
            if (isValid) {
                result.Add(word);
            }
        }
        
        return result;
    }
}
public class Solution {
    public IList<string> StringMatching(string[] words) {
        HashSet<string> result = new HashSet<string>(); // Use a HashSet to avoid duplicates
        
        for (int i = 0; i < words.Length; i++) {
            for (int j = 0; j < words.Length; j++) {
                if (i != j && words[j].Contains(words[i])) {
                    result.Add(words[i]); // Add the substring to the result
                    break; // No need to check further if we found a match
                }
            }
        }
        
        return new List<string>(result); // Convert HashSet to List and return
    }
}
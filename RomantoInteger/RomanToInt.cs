public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char,int> romanMap = new Dictionary<char,int> {
            {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50},
            {'C', 100}, {'D', 500}, {'M', 1000}
        };
          int total = 0;
          int prev = 0;
        foreach(char c in s){
            int curr = romanMap[c];
            total += curr;
      

          if (prev < curr) {
                total -= 2 * prev;
            }

            prev = curr;
       
        }
            return total;
    }
    
}
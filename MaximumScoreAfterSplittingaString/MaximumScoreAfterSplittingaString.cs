public class Solution {
    public int MaxScore(string s) {
        int maxScore = 0;
        for (int i=1;i<s.Length ; i ++ ) {

            int leftZeros = 0 ;
            int rigthZeros = 0 ;

            for (int j=0;j<i;j++ ) {
                    if (s[j] == '0') {
                        leftZeros ++;
                    }
  
            } 
            for (int j= i ; j< s.Length; j++) {
                if (s[j] == '1') {
                    rigthZeros ++;
                }
            }
        maxScore = Math.Max(maxScore, leftZeros + rigthZeros);        
        }
         return maxScore;
    }
   
}
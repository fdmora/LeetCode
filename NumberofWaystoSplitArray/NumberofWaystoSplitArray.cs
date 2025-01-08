public class Solution {
    public int WaysToSplitArray(int[] nums) {
               int n = nums.Length;
        long[] prefixSum = new long[n + 1];
        for (int i = 0; i < n; ++i) {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }
        int count = 0;
        for (int i = 1; i < n; ++i) {
            if (prefixSum[i] >= prefixSum[n] - prefixSum[i]) {
                count++;
            }
        }
        return count;
    }
}
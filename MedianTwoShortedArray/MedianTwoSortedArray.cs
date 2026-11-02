using System;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // Search the smaller array so the other partition stays in bounds.
        if (nums1.Length > nums2.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int leftSize = (m + n + 1) / 2;
        int low = 0;
        int high = m;

        while (low <= high) {
            int i = low + (high - low) / 2;
            int j = leftSize - i;

            int left1 = i == 0 ? int.MinValue : nums1[i - 1];
            int right1 = i == m ? int.MaxValue : nums1[i];
            int left2 = j == 0 ? int.MinValue : nums2[j - 1];
            int right2 = j == n ? int.MaxValue : nums2[j];

            if (left1 <= right2 && left2 <= right1) {
                if ((m + n) % 2 == 1) {
                    return Math.Max(left1, left2);
                }

                return ((double)Math.Max(left1, left2)
                    + Math.Min(right1, right2)) / 2.0;
            }

            if (left1 > right2) {
                high = i - 1;
            } else {
                low = i + 1;
            }
        }

        throw new ArgumentException("The arrays must be sorted.");
    }
}

public class Program {
    public static void Main() {
        var solution = new Solution();
        Console.WriteLine(solution.FindMedianSortedArrays(new[] { 1, 3 }, new[] { 2 }));
        Console.WriteLine(solution.FindMedianSortedArrays(new[] { 1, 2 }, new[] { 3, 4 }));
    }
}

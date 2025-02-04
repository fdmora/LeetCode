class Solution:
    def maxAscendingSum(self, nums: list[int]) -> int:
        if not nums:
            return 0

        max_sum = nums[0];
        current_sum = nums[0];

        for i in range(1, len(nums)):
            if nums[i] > nums[i - 1]:
                current_sum += nums[i]  # Add to the current ascending subarray
            else:
                current_sum = nums[i]  # Start a new ascending subarray

            if current_sum > max_sum:
                max_sum = current_sum  # Update max_sum if current_sum is greater

        return max_sum
        
# Example usage:
nums1 = [10, 20, 30, 5, 10, 50]
print(Solution.maxAscendingSum(nums1))  # Output: 65

nums2 = [10, 20, 30, 40, 50]
print(Solution.maxAscendingSum(nums2))  # Output: 150

nums3 = [12, 17, 15, 13, 10, 11, 12]
print(Solution.maxAscendingSum(nums3))  # Output: 33
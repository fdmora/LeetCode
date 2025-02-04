func maxAscendingSum(nums []int) int {
    if len(nums) == 0 {
		return 0
	}

	maxSum := nums[0]  // Initialize maxSum with the first element
	currentSum := nums[0]  // Initialize currentSum with the first element

	for i := 1; i < len(nums); i++ {
		if nums[i] > nums[i-1] {
			currentSum += nums[i]  // Add to the current ascending subarray
		} else {
			currentSum = nums[i]  // Start a new ascending subarray
		}

		if currentSum > maxSum {
			maxSum = currentSum  // Update maxSum if currentSum is greater
		}
	}

	return maxSum
    
}
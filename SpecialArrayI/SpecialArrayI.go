package main

import "fmt"

type Solution struct{}

func (s Solution) IsArraySpecial(nums []int) bool {
	for i := 0; i < len(nums)-1; i++ {
		if (nums[i] % 2) == (nums[i+1] % 2) {
			return false // Si dos elementos consecutivos tienen la misma paridad, no es especial
		}
	}
	return true // Si no se encontraron pares consecutivos con la misma paridad, es especial
}

func main() {
	sol := Solution{}
	fmt.Println(sol.IsArraySpecial([]int{2, 1, 4}))    // true
	fmt.Println(sol.IsArraySpecial([]int{4, 3, 1, 6})) // false
}

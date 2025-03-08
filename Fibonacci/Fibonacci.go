package main

import (
	"fmt"
)

func fibonacci(n int) []int {
	if n <= 2 {
		return []int{} // Devuelve una lista vacía si n <= 2
	}

	sequence := []int{1, 1}
	for i := 2; i < n; i++ {
		sequence = append(sequence, sequence[i-1]+sequence[i-2])
	}

	return sequence
}

func main() {
	var n int
	fmt.Print("Ingrese un número mayor que 2: ")
	fmt.Scan(&n)

	if n > 2 {
		fmt.Println("Secuencia de Fibonacci:", fibonacci(n))
	} else {
		fmt.Println("Error: El número debe ser mayor que 2.")
	}
}

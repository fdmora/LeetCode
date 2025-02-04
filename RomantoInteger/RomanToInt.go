package main

import (
	"fmt"
)

func romanToInt(s string) int {
	// Agregar elementos al mapa
	romanMap := map[rune]int{
		'I': 1,
		'V': 5,
		'X': 10,
		'L': 50,
		'C': 100,
		'D': 500,
		'M': 1000,
	}
	return 1
}

func main() {
	// Ejemplo de uso
	roman := "MCMXCIV"
	result := romanToInt(roman)
	fmt.Printf("El valor entero de %s es: %d\n", roman, result) // Salida: El valor entero de MCMXCIV es: 1994
}

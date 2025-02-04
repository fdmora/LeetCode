def roman_to_integer(s: str) -> int:
    # Mapping of Roman numerals to their integer values
    roman_map = {
        'I': 1,
        'V': 5,
        'X': 10,
        'L': 50,
        'C': 100,
        'D': 500,
        'M': 1000
    }
    
    total = 0
    prev_value = 0
    
    # Iterate over each character in the string
    for char in reversed(s):
        current_value = roman_map[char]
        
        # If the current value is less than the previous value, we subtract it
        if current_value < prev_value:
            total -= current_value
        else:
            total += current_value
        
        # Update the previous value
        prev_value = current_value
    
    return total

# Example usage
print(roman_to_integer("III"))      # Output: 3
print(roman_to_integer("LVIII"))    # Output: 58
print(roman_to_integer("MCMXCIV"))  # Output: 1994
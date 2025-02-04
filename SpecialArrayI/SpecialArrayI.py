class Solution:
    def isArraySpecial(self, nums: list[int]) -> bool:
        for i in range(len(nums)-1):
            if (nums[i]%2) == (nums[i + 1]%2):
                return False  # Si dos elementos consecutivos tienen la misma paridad, no es especial
        return True # Si no se encontraron pares consecutivos con la misma paridad, es especial
    

# Prueba en la consola
sol = Solution()
print(sol.isArraySpecial([2, 1, 4]))  # True
print(sol.isArraySpecial([4, 3, 1, 6]))  # False
public class Solution
{
    public bool IsArraySpecial(int[] nums)
    {

        for (int i = 0; i < nums.Length - 1; i++)
        {
            if ((nums[i] % 2) == (nums[i + 1] % 2))
            {
                return false; // Si dos elementos consecutivos tienen la misma paridad, no es especial
            }
        }
        return true; // Si no se encontraron pares consecutivos con la misma paridad, es especial
    }
}
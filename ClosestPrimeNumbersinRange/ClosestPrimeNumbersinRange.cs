public class Solution {
    public int[] ClosestPrimes(int left, int right) {
        
        int MAX_N = 1000000;
        bool[] isPrime = new bool[MAX_N + 1];

        // Inicializar la criba de Eratóstenes
        Array.Fill(isPrime, true);
        isPrime[0] = isPrime[1] = false; // 0 y 1 no son primos

        for (int num = 2; num * num <= MAX_N; num++)
        {
            if (isPrime[num])
            {
                for (int multiple = num * num; multiple <= MAX_N; multiple += num)
                {
                    isPrime[multiple] = false;
                }
            }
        }

        // Obtener los primos en el rango [left, right]
        List<int> primes = new List<int>();
        for (int num = left; num <= right; num++)
        {
            if (isPrime[num])
            {
                primes.Add(num);
            }
        }

        // Si hay menos de 2 primos, no se puede formar un par
        if (primes.Count < 2)
        {
            return new int[] { -1, -1 };
        }

        // Encontrar el par de primos con menor diferencia
        int minDiff = int.MaxValue;
        int[] closestPair = new int[2];

        for (int i = 0; i < primes.Count - 1; i++)
        {
            int diff = primes[i + 1] - primes[i];
            if (diff < minDiff)
            {
                minDiff = diff;
                closestPair[0] = primes[i];
                closestPair[1] = primes[i + 1];
            }
        }

        return closestPair;
    }
}
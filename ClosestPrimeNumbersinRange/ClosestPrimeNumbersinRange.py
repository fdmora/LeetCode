class Solution(object):
    def closestPrimes(self, left, right):
        MAX_N = 10**6  # Límite superior según las restricciones    

        # Paso 1: Criba de Eratóstenes para encontrar primos hasta MAX_N
        is_prime = [True] * (MAX_N + 1)
        is_prime[0] = is_prime[1] = False  # 0 y 1 no son primos    

        for num in range(2, int(MAX_N**0.5) + 1):
            if is_prime[num]:
                for multiple in range(num * num, MAX_N + 1, num):
                    is_prime[multiple] = False  

        # Paso 2: Obtener los primos en el rango [left, right]
        primes = [num for num in range(left, right + 1) if is_prime[num]]   

        # Paso 3: Encontrar el par de primos más cercano
        if len(primes) < 2:
            return [-1, -1] 

        min_diff = float('inf')
        closest_pair = [-1, -1] 

        for i in range(len(primes) - 1):
            diff = primes[i + 1] - primes[i]
            if diff < min_diff:
                min_diff = diff
                closest_pair = [primes[i], primes[i + 1]]   

        return closest_pair 

    # Ejemplo de uso
    # print(closestPrimes(10, 19))  # Salida esperada: [11, 13]
    # print(closestPrimes(4, 6))    # Salida esperada: [-1, -1]
// Función principal
func magnificentSets(n int, edges [][]int) int {
	// Construcción del grafo con lista de adyacencia
	graph := make(map[int][]int)
	for i := 1; i <= n; i++ {
		graph[i] = []int{}
	}
	for _, edge := range edges {
		graph[edge[0]] = append(graph[edge[0]], edge[1])
		graph[edge[1]] = append(graph[edge[1]], edge[0])
	}

	// Mapa de colores para verificar si es bipartito
	colors := make(map[int]int)
	var components [][]int

	// BFS para verificar bipartitismo y extraer componentes conexas
	bfsCheckBipartite := func(start int) ([]int, bool) {
		queue := list.New()
		queue.PushBack([2]int{start, 0})
		component := []int{}

		for queue.Len() > 0 {
			elem := queue.Front()
			queue.Remove(elem)
			node, color := elem.Value.([2]int)[0], elem.Value.([2]int)[1]

			if col, exists := colors[node]; exists {
				if col != color {
					return nil, false // No es bipartito
				}
				continue
			}

			colors[node] = color
			component = append(component, node)

			for _, neighbor := range graph[node] {
				queue.PushBack([2]int{neighbor, 1 - color})
			}
		}
		return component, true
	}

	// Explorar cada nodo para encontrar componentes conexas
	for i := 1; i <= n; i++ {
		if _, visited := colors[i]; !visited {
			component, isBipartite := bfsCheckBipartite(i)
			if !isBipartite {
				return -1 // No es posible agrupar
			}
			components = append(components, component)
		}
	}

	// BFS para calcular la profundidad máxima de cada componente
	maxDepth := func(start int) int {
		queue := list.New()
		queue.PushBack(start)
		visited := make(map[int]bool)
		visited[start] = true
		depth := 0

		for queue.Len() > 0 {
			size := queue.Len()
			for i := 0; i < size; i++ {
				elem := queue.Front()
				queue.Remove(elem)
				node := elem.Value.(int)

				for _, neighbor := range graph[node] {
					if !visited[neighbor] {
						visited[neighbor] = true
						queue.PushBack(neighbor)
					}
				}
			}
			depth++
		}
		return depth
	}

	// Sumar las profundidades máximas de cada componente
	maxGroups := 0
	for _, component := range components {
		localMax := 0
		for _, node := range component {
			localMax = max(localMax, maxDepth(node))
		}
		maxGroups += localMax
	}

	return maxGroups
}

// Función auxiliar para obtener el máximo de dos números
func max(a, b int) int {
	if a > b {
		return a
	}
	return b
}

public class MinimumSwaps2{
    public static int minimumSwaps(int[] arr) {
    int n = arr.Length;
    bool[] visited = new bool[n];
    int swaps = 0;

    for (int i = 0; i < n; i++) {
        // Если элемент уже на своём месте или был посещён, пропускаем
        if (visited[i] || arr[i] == i + 1)
            continue;

        // Начинаем цикл с элемента, который не на своём месте
        int cycleSize = 0;
        int j = i;
        while (!visited[j]) {
            visited[j] = true;
            j = arr[j] - 1;  // Переходим на позицию элемента в правильном порядке
            cycleSize++;
        }

        // Если цикл из k элементов, то нужно k-1 обменов
        if (cycleSize > 0) {
            swaps += (cycleSize - 1);
        }
    }

    return swaps;
}

}
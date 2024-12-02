function quick_sort($array, $low = 0, $high = null) {
    if ($high === null) {
        $high = count($array) - 1;
    }

    if ($low < $high) {
        // Escolhe o pivô aleatório
        $pivotIndex = rand($low, $high);
        swap($array, $pivotIndex, $high);
        $pivot = $array[$high];

        $i = $low - 1;
        for ($j = $low; $j < $high; $j++) {
            if ($array[$j] <= $pivot) {
                $i++;
                swap($array, $i, $j);
            }
        }

        swap($array, $i + 1, $high);
        $partitionIndex = $i + 1;

        quick_sort($array, $low, $partitionIndex - 1);
        quick_sort($array, $partitionIndex + 1, $high);
    }

    return $array;
}

function swap(&$array, $i, $j) {
    $temp = $array[$i];
    $array[$i] = $array[$j];
    $array[$j] = $temp;
}
public class CountTriplets{

    public static long countTriplets(List<long> arr, long r) {

        long count = 0;
      
        for (int i=0;i<arr.Count;i++)
        {
            for(int j=1; j<arr.Count;j++)
            {
                for(int k = 2; k<arr.Count;k++)
                {
                    List<long> ratioArr = new List<long>();
                    if(arr[i]==1||arr[i]%r==0){
                        ratioArr.Add(arr[i]);
                    }
                    if(arr[j]==arr[i]*r)
                    {
                        ratioArr.Add(arr[j]);
                    }
                    if(arr[k]==arr[j]*r)
                    {
                        ratioArr.Add(arr[k]);
                    }
                    if(ratioArr.Count==3){
                        count++;
                        
                    }
                }
            }
        }
        return count;
    }

    public static long countTripletsOtpimized(List<long> arr, long r) {
        var potentialPairs = new Dictionary<long, long>();
    var tripletCount = new Dictionary<long, long>();
    long count = 0;

    foreach (long num in arr) {
        // Завершаем тройки
        if (tripletCount.ContainsKey(num)) {
            count += tripletCount[num];
        }

        // Обновляем тройки для следующего возможного элемента
        if (potentialPairs.ContainsKey(num)) {
            if (!tripletCount.ContainsKey(num * r)) {
                tripletCount[num * r] = 0;
            }
            tripletCount[num * r] += potentialPairs[num];
        }

        // Обновляем potentialPairs для новых троек
        if (!potentialPairs.ContainsKey(num * r)) {
            potentialPairs[num * r] = 0;
        }
        potentialPairs[num * r]++;
    }

    return count;
    }
    
    public static long countTriplets2(List<long> arr, long r) {
    long count = 0;

    Dictionary<long, long> pairs = new Dictionary<long, long>();
    Dictionary<long, long> triplets = new Dictionary<long, long>();

    foreach (long number in arr) {
        // Если число завершает триплет
        if (triplets.ContainsKey(number)) {
            count += triplets[number];
        }

        // Если число может продолжить пару
        if (pairs.ContainsKey(number)) {
            if (!triplets.ContainsKey(number * r)) {
                triplets[number * r] = 0;
            }
            triplets[number * r] += pairs[number];
        }

        // Добавляем число как начало пары
        if (!pairs.ContainsKey(number * r)) {
            pairs[number * r] = 0;
        }
        pairs[number * r]++;
    }

    return count;
}


}
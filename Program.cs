static void PrintNumbers(){
    for(int i = 1; i <= 255; i++ ){
        Console.WriteLine(i);
    }
}
// PrintNumbers();

static void PrintOdds(){
    for(int i = 1; i <= 255; i++ ){
        if(i % 2 != 0){
            Console.WriteLine(i);
        }
    }
}
// PrintOdds();

static void PrintSum(){
    int sum = 0;
    for(int i = 0; i <= 255; i++ ){
        sum += i;
    }
    Console.WriteLine(sum);
}
// PrintSum();

static void LoopArray(int[] numbers){
    foreach(int num in numbers){
        Console.WriteLine(num);
    }
}
// int [] nums = {1,9,3,6,5};
// LoopArray(nums);

static void FindMax(int[] numbers){
    int max = int.MinValue;
    for(int i = 0; i < numbers.Length; i++){
        if(numbers[i] > max){
            max = numbers[i];
        }
    }
    Console.WriteLine(max);
}
// int [] nums = {1,9,3,6,5};
// FindMax(nums);

static void GetAverage(int[] numbers){
    double avg = 0;
    int sum = 0;
    foreach(int num in numbers){
        sum += num;
    }
    avg = (double) sum / numbers.Length;
    Console.WriteLine(avg);
}
// int [] nums = {1,9,3,6,5};
// GetAverage(nums);

static int[] OddArray(){
    List<int> odds = new List<int>();
    for(int i = 1; i <= 255; i++){
        if(i%2 != 0){
            odds.Add(i);
        }
    }
    return odds.ToArray();
}
// OddArray();

static int GreaterThanY(int[] nums, int y){
    int count = 0;
    foreach(int i in nums){
        if(i > y){
            count++;
        }
    }
    Console.WriteLine(count);
    return count;
}
// int [] nums = {1,9,3,6,5};
// GreaterThanY(nums, 4);

static void SquareArrayValues(int[] nums){
    for(int i = 0; i < nums.Length; i++){
        nums[i] = nums[i]*nums[i];
    }
}
// int [] nums = {1,9,3,6,5};
// SquareArrayValues(nums);

static void EliminateNegatives(int[] nums){
    List<int> myList = new List<int>();
    for(int i = 0; i < nums.Length; i++){
        if(nums[i] >= 0){
            myList.Add(nums[i]);
        }
    }
    nums = myList.ToArray();
}
// int [] nums = {1,-9,3,-6,5};
// EliminateNegatives(nums);

static void MinMaxAverage(int[] nums){
    int min = int.MaxValue;
    int max = int.MinValue;
    int avg = 0;
    foreach(int i in nums){
        if(i < min){
            min = i;
        }
        if(i > max){
            max = i;
        }
        avg += i;
    }
}
// int [] nums = {1,-9,3,-6,5};
// MinMaxAverage(nums);

static void ShiftValues(int[] nums){
    for(int i = 0; i < nums.Length - 1; i++){
        nums[i] = nums[i + 1];
    }
    nums[nums.Length - 1] = 0;
    Array.ForEach(nums, Console.WriteLine);
}
// int [] nums = {1,-9,3,-6,5};
// ShiftValues(nums);

static object[] NumToString(int[] nums){
    List<object> myList = new List<object>();
    for(int i = 0; i < nums.Length; i++){
        if(nums[i] < 0){
            myList.Add("Dojo");
        }
        else{
            myList.Add(nums[i]);
        }
        // Console.WriteLine(myList[i]);
    }
    return myList.ToArray();
}
int [] nums = {1,-9,3,-6,5};
NumToString(nums);
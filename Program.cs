
static int[]  RandomArray(){
    int[] someArray = new int[10];
    Random rand = new Random();
    for(int i = 0;i < 10;i++){
        someArray[i] = rand.Next(5,25);
        Console.WriteLine(someArray[i]);
    }
        int sum = someArray.Sum();
        Console.WriteLine($" this is the max value in the array {someArray.Max()} .");
        Console.WriteLine($" this is the min value in the array {someArray.Min()} .");
        Console.WriteLine($"this is the sum of all the values in teh array {sum} .");
        return someArray;
} 

RandomArray();

static int[]  RandomArray(){
    int[] someArray = new int[10];
    Random rand = new Random();
    for(int i = 0;i < 10;i++){
        someArray[i] = rand.Next(5,25);
        Console.WriteLine(someArray[i]);
    }
        int a,max,min,n;
        n =10;
        max = someArray[0];
        min = someArray[0];
        for(a = 1; a < n ; a++){
            if(someArray[a] > max){
                max = someArray[a];
            }
            if(someArray[a] < min ){
                min = someArray[a];
            }
        }
        
        int sum = someArray.Sum();
        
        Console.WriteLine($" this is the max value in the array {max} .");
        Console.WriteLine($" this is the min value in the array {min} .");
        Console.WriteLine($"this is the sum of all the values in teh array {sum} .");
        return someArray;
} 

RandomArray();

static int[]  RandomArray(){
    int[] someArray = new int[10];
    Random rand = new Random();
    for(int i = 0;i < 10;i++){
        someArray[i] = rand.Next(5,25); // setting the item inside of the array to be random numbers 
        Console.WriteLine(someArray[i]);
    }
        int sum = someArray.Sum(); // getting the sum of all the items in the array
        Console.WriteLine($" this is the max value in the array {someArray.Max()}."); //getting the greater values in the array
        Console.WriteLine($" this is the min value in the array {someArray.Min()}."); //getting the lowest values in the array
        Console.WriteLine($"this is the sum of all the values in teh array {sum}.");
        return someArray;
} 

RandomArray();


static int TossCoin(){
    Random rand = new Random();
    Console.WriteLine("Tossing Coin");
    int n = rand.Next(1,3);
        if(n == 1){
            Console.WriteLine("the coin landed on Heads");
        }
        else if(n == 2){
            Console.WriteLine("the coin landed on Tails");
        }
        else{
        Console.WriteLine("is a draw some how  toss again");
        }
        return n ;
    }

TossCoin();


static List<string> Names(){
    List<string> listNames = new List<string> {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
    foreach(string item in listNames){
        if(item.Length > 5){ // seeing the length of the items in the list
            Console.WriteLine(item);
        }
    }
    return listNames;
}

Names();
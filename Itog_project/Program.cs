void methodStringArray (string [] array)
{
     string[] myArray = new string[array.Length];
     for (int i=0; i<array.Length; i++){      
        if(array[i].Length<=3){
        myArray[i]=array[i];;
        Console.WriteLine(myArray[i]); 
        }
     }
        Console.WriteLine(); 
}

void Print(string [] Array){
    for (int i=0; i<Array.Length; i++){
        Console.WriteLine(Array[i]);
    }
    Console.WriteLine();
}

string [] array = {"hjklfg", "256", "wor", "mm1", "7"};

Print(array);
Console.WriteLine("Полученный массив:");
methodStringArray(array);
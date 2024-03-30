int [] GetAnArray(int size) {
   int [] array = new int[size];
   for (int i = 0; i < size; i++){
    Console.Write("Insert a number: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
   }
   return array;
}

int [] array = GetAnArray(8);

Console.Write(string.Join(",", array));
Console.Write(" -> [");
Console.Write(string.Join(",", array));
Console.Write("]");


    void Zadacha57()
{
    // Составьте частотный словарь элементов двумерного массива
    //частотный словарь содеожит информацию о том,сколько раз встречается элемент входныйх данных.
    Random random = new Random();
    int rows = random.Next(2, 6);
    int columns = random.Next(3, 6);
  
 
    int[,] array = new int[rows, columns];
    int[] dictionary = new int[10];
    FillArray(array);
    PrintArray(array);  
    for (int i = 0; i < rows; i++)
     {
        for (int j = 0; j < columns; j++)
        {
           dictionary[array[i, j]] ++;
        }
     }
    Console.WriteLine();
    for (int i = 0; i < dictionary.Length; i++)
    {
        Console.WriteLine($"Элемент {i} встречается {dictionary[i]} раз");
    }


    
 void FillArray(int[,] array)
    {

     for (int i = 0; i < rows; i++)
     {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0 , 10);
        }
     }
    }

 void PrintArray(int[,] array)
    {
     Console.WriteLine();
 
     for (int i = 0; i < rows; i++)
        {
           for (int j = 0; j < columns; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
        }
        Console.WriteLine();

    }

}   
    //Zadacha57();
    Zadacha57();
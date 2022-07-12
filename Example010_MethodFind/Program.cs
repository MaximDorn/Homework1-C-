int[] array = {3, 423, 53, 4, 32, 1, 2, 3, 543, 4, 21};

int n = array.Length;
int find = 4;

 int index = 0;
 
 while (index < n)
 {
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
 }
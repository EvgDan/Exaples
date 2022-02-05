int [] array ={1,2,3,46,5, 46,6,7,8};
int n = array.Length;
int find = 46;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
      Console.WriteLine(index);  
      break;
    }
   index++; // index = index + 1;
}
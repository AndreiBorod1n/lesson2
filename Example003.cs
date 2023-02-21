int [] array = {13, 25, 38, 42, 51, 66, 73, 89};

int n = array.Length;
int find = 73;

int index = 0;


while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    
    //index = index + 1;
    index ++;
}



 
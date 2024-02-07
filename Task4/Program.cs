int n = 5;
int[] array = { 2, 4, 9, 3, 8 };
int i = 0;
int max = array[0];

while (i < n) // цикл while обращается к индексу элемента массива и позволяет перезаписывать индекс
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i = i + 1;
}
Console.WriteLine(max);

max = array[0];
for (int j = 0; j < n; j++) // цикл for обращается к индексу элемента массива и позволяет перезаписывать индекс
{
    if (array[j] > max)
    {
      max = array[j]; 
    }
}
Console.WriteLine(max);

max = array[0];
foreach (int e in array) // цикл foreach не обращается к индексу элемента массива и не позволяет перезаписывать индекс элемента, вместо этого создается переменная в которую записываются или копируются элементы массива
{
    if (e > max)
    {
      max = e; 
    }
}
Console.WriteLine(max);
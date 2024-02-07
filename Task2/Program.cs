int n = 10; //n это переменная
int[] arr = new int[n];
int i = 0;

while (i < arr.Length) //arr.Length вместо переменной n
{
    arr[i] = i + 1;
    //System.Console.WriteLine(arr[i]);
    //System.Console.WriteLine(' ');
    Console.Write($"{arr[i]} "); //упрощение кода
    i = i + 1;
}
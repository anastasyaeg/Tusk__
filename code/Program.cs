int[] CreateArray(int lenght)
{
return new int[lenght];
}

void FillArray(int[] array, int min, int max)
{
string res = string.Empty;
for (int i = 0; i < array.Length; i++)
{
array[i] = new Random().Next(min, max);
}
}

string PrintArray(int[] array)
{
string res = string.Empty;
for (int i = 0; i < array.Length; i++)
{
res += $"{array[i]} ";
}
return res;
}

int count = 0;
int Counter(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0) count = count + 1;
}
return count;
}

void FillNewArray(int[] array, int[] newarray)
{
string res = string.Empty;
int j = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
{
newarray[j] = array[i];
j = j + 1;
}
}
}
int[] Array = CreateArray(9);
FillArray(Array, 1, 10);
Console.WriteLine(PrintArray(Array));
Counter(Array);
int[] NewArray = CreateArray(count);
FillNewArray(Array,NewArray);
Console.WriteLine(PrintArray(NewArray));

string [] array = {"Hello", "2", "world", ":-)"};
if (array.Length == 0)
{
    array = Console.ReadLine()!.Split(" ");
}
string [] new_array = array;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        Console.Write("{0} ", new_array[i]);
    }
    else
    {
        new_array[i] = "";
    }
}

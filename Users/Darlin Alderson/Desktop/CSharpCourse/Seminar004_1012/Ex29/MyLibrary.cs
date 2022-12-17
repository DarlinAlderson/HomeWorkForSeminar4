public class MyLibrary
{
//Создание массива
public static int [] CreateArray (int count)
{
return int[count];
}
//Заполнение числами 0-14
public static void Fill (int [] array)
{
    for (int i = 0; i < array.length; i++)
    {
        array [i] = Random.Shared.Next (0, 15);
    }
}
//Печать массива
public static string Print (int [] array)
{
    return String.Join(' ', array);
}

//Написать конвертер из 15-ой СС в 10-ую
public static int ToDec(int [] value)
{
    int result = 0;
    int count = value.Length;
    for (int i = 0; i < count; i++)
    {
       result += value[i] * Math.Pow(15, count-1-i); 
    }
    return 0;
}
}
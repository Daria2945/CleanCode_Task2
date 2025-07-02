public static int SearchIndex(int[] array, int element)
{
    if(array == null)
        throw new ArgumentNullException(nameof(array));

    if (array.Length == 0)
        throw new ArgumentException($"{nameof(array)} не был заполнен");

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == element)
            return i;
    }

    return -1;
}
foreach (var el in move_zero_to_end(new List<int>() { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }))
{
    Console.Write($"{el} ");
}

static List<int> move_zero_to_end(List<int> input)
{
    List<int> output = new List<int>();
    int zero_count = 0;
    foreach (var el in input)
    {
        if (el == 0)
        {
            zero_count++;
        }
        else
        {
            output.Add(el);
        }
    }

    for (int i = 0; i < zero_count; i++)
    {
        output.Add(0);
    }
    return output;
}
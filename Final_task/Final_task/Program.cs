string[] start = new string[7] { "Story", "year", "new", "123", "res","task","a" };
string[] end = new string[start.Length];
int count = 0;
for (int i = 0; i < start.Length; i++)
    {
        if (start[i].Length <= 3)
        {
            end[count] = start[i];
            count++;
        }
    }

for (int i = 0; i < end.Length; i++)
    {
        Console.Write($"{end[i]} ");
    }
    Console.WriteLine();
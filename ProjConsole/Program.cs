int size = 20;
int[] arrUnord = new int[size];
int ord;
bool swap = false;
Random random = new();

for (int i = 0; i < size; i++)
{
    arrUnord[i] = random.Next(1, 1000);
}

PrintArr();

void PrintArr() {
    for (int i = 0; i < size; i++)
    {
        Console.Write(arrUnord[i] + " ");
    }
    Console.WriteLine("\n");
}

// Array.Sort(arrUnord);

do {
    swap = false;
    for (int i = 0; i < size-1; i++)
    {
        if (arrUnord[i] > arrUnord[i+1]) {
            ord = arrUnord[i];
            arrUnord[i] = arrUnord[i+1];
            arrUnord[i+1] = ord;
            swap = true;
        }
    }
} while (swap);

// BubbleSort();

PrintArr();
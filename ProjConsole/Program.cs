using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

int size = 20;
int[] arrUnord = new int[size];
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

Array.Sort(arrUnord);

PrintArr();
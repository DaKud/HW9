// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Insert initial iteger number: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Insert finite iteger number: ");
int N = int.Parse(Console.ReadLine());
int Border = M-1;

int MtoNRow (int M, int N)
{
    if(N == Border)
    {
        return 0;
    }
    Console.WriteLine(N);
    return MtoNRow(M+1, N-1)+M;
}
Console.WriteLine($" Sum of numbers from {M} to {N} = {MtoNRow(M,N)}");
// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"
// M = 8; N = 4. -> "8, 7, 6, 5, 4"

Console.WriteLine("Insert initial iteger number: ");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Insert finite iteger number: ");
int N = int.Parse(Console.ReadLine());

(int InitialNumber, int FiniteNumber ) MinMax (int InitialNumber, int FiniteNumber)    // chck if Initial number is less than Finite number
{
    int tmp;
    if(InitialNumber>FiniteNumber)
    {
        tmp=InitialNumber;
        InitialNumber = FiniteNumber;
        FiniteNumber = tmp;
    }
    return(InitialNumber,FiniteNumber);

}
void MtoNRow (int InitialNumber, int FiniteNumber)
{
    if (InitialNumber > FiniteNumber) return;    // if == then if the answer would be the  row of nubers TILL Finite number (e.g. Finite: 5 ANSW: 1,2,3,4 )
    Console.WriteLine(InitialNumber);
    MtoNRow(InitialNumber+1,FiniteNumber );
}

Console.WriteLine();
(N,M) = MinMax(N,M);  // invoke MaxMin function
MtoNRow(N,M);
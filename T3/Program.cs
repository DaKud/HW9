// Задача 68: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

int m =2;
int n =3;

int Ackerman (int m, int n)
{
    if(m==0)
    {
        return n+1;
    }
    if(m>0 && n==0)
    {
        return Ackerman(m-1,1);
    }
    if(m>0 && n>0)
    {
        return Ackerman(m-1,Ackerman(m,n-1));
    }
    return 0_0;
}
Console.WriteLine(Ackerman(m,n));
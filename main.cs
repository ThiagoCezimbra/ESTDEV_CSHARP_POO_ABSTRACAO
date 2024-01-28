using System;
class Program

{
    public static void Main (string[] args)
{
    Retangulo r1 = new Retangulo(); ;
    r1.Base = 10;
    r1.Altura = 40;

    Retangulo r2 = new Retangulo(); ;
    r2.Base = 12;
    r2.Altura = 47;

    r1.Escrever();
    r2.Escrever();


    int a1 = r1.CalcArea();
    int a2 = r2.CalcArea();

    Console.WriteLine($" Valor:  {a1} valor: {a2} ");

}
}   
using System;

public abstract class Veiculo
{
    protected int TaxaDiaria { get; set; }
    public abstract int CalcularValorTotal(int numDiarias);
}
public class Carro : Veiculo
{
    public Carro(int taxaDiaria)
    {
        TaxaDiaria = taxaDiaria;
    }
    public override int CalcularValorTotal(int numDiarias)
    {
        return TaxaDiaria * numDiarias;
    }
}
public class Moto : Veiculo
{
    public Moto(int taxaDiaria)
    {
        TaxaDiaria = taxaDiaria;
    }
    public override int CalcularValorTotal(int numDiarias)
    {
        return TaxaDiaria * numDiarias;
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro(50);
        int valorTotalCarro = carro.CalcularValorTotal(10);
        Console.WriteLine($"Valor total para Carro 10 diarias: R$ {valorTotalCarro}");
        Moto moto = new Moto(25);
        int valorTotalMoto = moto.CalcularValorTotal(10);
        Console.WriteLine($"Valor total para Moto 10 diarias: R$ {valorTotalMoto}");
    }
}
using System;
/*AQUI TEMOS REPRESENTADO CLASSE ABSTRATA E HERANÇA*/
public abstract /*QUE É ABSTRATA*/ class Forma/*NOME CLASSE*/
{

    /*ÉPROTECT POR MUITOS MOTIVOS, REVEJA-OS E POR ENQUANTO APENAS SAIBA QUE É ASSIM NO CASO DE CLASSE ABSTRATA*/

    protected double _base;
    protected double _altura;
    /*FIM DA DESCRIÇÃO DE ATRIBUTOS*/

    /*INICIO DOS MÉTODOS GETTER E SETTERS - PODEMOS CHAMAR DE METODOS DE ACESSO*/

    public double Basee /*ACERTANDO GETTER E SETTER*/
    {

        get { return _base; }
        set { _base = value; }

    }
    public double Altura /*ACERTANDO GETTER E SETTER*/
    {

        get { return _altura; }
        set { _altura = value; }
    } /*FIM METODO ACESSOR*/
    /*AGORA VEM O "MÉTODO" DA CLASSE ABSTRATA, QUE SERÁ APLICADA NAS DEMAIS*/
    public abstract double CalcularArea();
} /* FIM DA CLASSE ABSTRATA */

/*CRIANDO A CLASSE RETANGULO - O DOIS PONTOS É COMO SE DISSESSE (HERDE DE)*/

class Retangulo : Forma /*CRIADA A CLASSE RETANGULO - O DOIS PONTOS É COMO SE DISSESSE (HERDE DE)*/
{
    /*METODO CONSTRUTOR*/
    public Retangulo(double bass, double altura)
    {

        base.Basee = bass;
        base.Altura = altura;


    }
    /*AGORA O METODO PARA CALC AREA*/

    public override double CalcularArea()
    {

        return base.Basee * base.Altura;

    }
} /* FIM DA CLASSE RETANGULO */

class Triangulo : Forma
{

    public Triangulo(double bass, double altura)
    {
        base.Basee = bass;
        base.Altura = altura;

    }

    public override double CalcularArea()
    {

        return (base.Basee * base.Altura) / 2;

    }
  
  
} /* FIM DA CLASSE TRIANGULO */

class Quadrado : Forma
{

    public Quadrado(double bass, double altura)
    {
        base.Basee = bass;
        base.Altura = altura;

    }

    public override double CalcularArea()
    {

        return (base.Basee * base.Altura);

    }
  }

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Qual walor da altura do retangulo?");

        Retangulo retangulobj = new Retangulo(5, 10);
        double areadoretangulo = retangulobj.CalcularArea();
        Console.WriteLine("Area do retungulo é:" + areadoretangulo);

        Triangulo trianguloobj = new Triangulo(5, 10);
        double areadotriangulo = trianguloobj.CalcularArea();
        Console.WriteLine("Area do retungulo é:" + areadotriangulo);

        Retangulo retangulobj2 = new Retangulo(6, 10);
        double areadoretangulo2 = retangulobj2.CalcularArea();
        Console.WriteLine("Area do retungulo é:" + areadoretangulo2);

        Quadrado quadradoobj = new Quadrado(6, 10);
        double areadoquadrado = quadradoobj.CalcularArea();
        Console.WriteLine("Area do retungulo é:" + areadoquadrado);
  
    }




}




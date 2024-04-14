using System;
/* MAIS CODIGO COM POLIMORFISMO E HERANÇA + SOBRECARGA DE METODO*/

public abstract class Animal
{


    protected string Nome { get; set; }
    protected int Idade { get; set; }

    public abstract void EmitirSom();
    public abstract void EmitirSom(string texto);


}

public class Cachorro : Animal
{

    public override void EmitirSom()
    {
        Console.WriteLine("Latindo");
    }

    public override void EmitirSom(string texto)
    {

        Console.WriteLine(texto);

    }

}

public class Gato : Animal
{

    public override void EmitirSom()
    {
        Console.WriteLine("Miando");

    }
    public override void EmitirSom(string texto)
    {
        Console.WriteLine(texto);

    }

  }
    public class Papagaio : Animal
    {

        public override void EmitirSom()
        {
            Console.WriteLine("Loro");

        }
        public override void EmitirSom(string texto)
        {
            Console.WriteLine(texto);

        }

        /*METODO DE ESPECIALIZAÇÃO? SOMENTE DO PAPAGAIO*/

        public void Repetir(string texto)
        {
            Console.WriteLine("Repetindo" + texto);
        }

    }


class Program
{
    static void Main(string[] args)
    {
      Cachorro C1 = new Cachorro();
      C1.EmitirSom();
      
      Gato G1 = new Gato();
      G1.EmitirSom();
      
      Papagaio P1 = new Papagaio();
        P1.EmitirSom();
      P1.EmitirSom("teste");


    Animal A1 = new Papagaio();
      A1.EmitirSom();
      A1.EmitirSom("papagaio 2");

      


    }
}



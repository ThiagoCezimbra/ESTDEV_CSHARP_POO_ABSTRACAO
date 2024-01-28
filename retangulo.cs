using System;
/*ABSTRAÇÃO É UM CONJUNTO DE ITENS, QUE VOCÊ DA NOME E "ESCONDE"*/

//representando o retangulo pelo class, eu agrupo as variáveis e dou uma nomenclatura// Isso é uma classe. A classe acaba sendo um agrupamento de varáveis


class Retangulo
{


  public /*(PUBLIC) de onde vem a varável - tipo de variavel - nome da variável*/  int Base;
  public /*(PUBLIC) de onde vem a varável - tipo de variavel - nome da variável*/ int Altura;

    public void Escrever(){

Console.WriteLine($"Base: {this.Base} Altura: {this.Altura}");


      /*Usando o this. voce está dizendo: Quero usar isso que esta dentro dessa classe*/
    }
  
public int CalcArea () {

int area = this.Base*this.Altura;
/* colocamos também uma função */
  return area;

  }

  
}


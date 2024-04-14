using System;

/*CODIGO DESENVOLVIMENTO POR MIM A PARTIR DA AULA 01 DA MATERIA DE POO - TEMA NO NOME DO ARQUIVO*/


class Conta
{
    /* Defino os atributos*/
    int agencia;
    int contaa;
    string nome;
    string instituicao;
    string situacao;

    /*PROPRIEDADES*/
    public string Beneficiario { get; set; }

    /*CONSTRUTORES E METODOS ACESSORES*/

    /*note que é uma pequena função*/
    public Conta()
    {
        this.instituicao = "Itaú";
    }
    /*outra pequena função*/
    public Conta(string instituicao)
    {
        this.instituicao = instituicao;
    }
    public string getinstituicao()
    { /*get e set são os chamados métodos acessores (busca e alteração)*/
        return this.instituicao;
    }
    public void setinstituicao(string instituicao)
    {
        this.instituicao = instituicao;
    }
    public Conta(int agencia) //começo instaNciamento
    {
        this.agencia = agencia;
    }
    public int getagencia()
    { /*get e set são os chamados métodos acessores (busca e alteração)*/
        return this.agencia;
    }
    public void setagencia(int agencia)
    {
        this.agencia = agencia;
    }
      
    

}

class Program
{

    public static void Main(string[] args)
    {

        Conta novaConta = new Conta(); /*aqui eu estou dizendo que o OBJETO novaConta é referente a classe Conta*/
        string instituicaoVar = novaConta.getinstituicao(); /*INDO BUSCAR INFO NO CONSTRUTOR - pedindo para buscar a inf da insituicao pré estabelecida*/

        Console.WriteLine("Insituição inicial é: " + instituicaoVar);/*printando informação acima*/

        novaConta.setinstituicao("Bradesco");/*aqui estamos dizendo que o atributo mudou (SETANDO - INSTANCIANDO O OBJETO)*/

        instituicaoVar = novaConta.getinstituicao(); /*pedindo para ele buscar a informação nova*/

        Console.WriteLine("Instituição atualizada é " + instituicaoVar);/*printando informação acima*/

        novaConta.setagencia(1044);/*aqui estamos dizendo que o atributo mudou (SETANDO - INSTANCIANDO O OBJETO)*/
        int agenciainst = novaConta.getagencia();
        Console.WriteLine("Instituição atualizada é " + agenciainst);/*printando informação acima*/


    }











}
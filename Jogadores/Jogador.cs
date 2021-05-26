using System;

namespace Elevador
{
    public abstract class Jogador
    {
        protected string nome;
        protected int data;
        protected string nacionalidade;
        protected double altura;
        protected int peso;
        protected int idade;
        public string Dados()
        {
            Console.WriteLine("Qual o nome do jogador?");
            nome = Console.ReadLine();

            Console.WriteLine("Em que ano o jogador nasceu?");
            data = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nacionalidade do jogador?");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("Qual a altura do jogador?");
            altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual o peso do jogador?");
            peso = int.Parse(Console.ReadLine());

            return $@"
    Nome: {nome}
    Ano de nascimento: {data}
    Nacionalidade: {nacionalidade}
    Altura: {altura}
    Peso : {peso}
            ";
        }
        public void CalcularIdade()
        {
            idade = (DateTime.Now.Date.Year) - data;
        }
    }
}
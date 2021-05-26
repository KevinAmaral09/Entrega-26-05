using System;

namespace Elevador
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = true;

            do
            {
                Console.WriteLine(@"
    O jogador joga no:
    1 - Ataque
    2 - Defesa
    3 - Meio-Campo
            ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        JogadorAtaque a = new JogadorAtaque();
                        Console.WriteLine(a.Dados());
                        Console.WriteLine(a.Aposentar());


                        break;
                    case 2:
                        JogadorDefesa d = new JogadorDefesa();
                        Console.WriteLine(d.Dados());
                        Console.WriteLine(d.Aposentar());

                        break;
                    case 3:
                        JogadorMeio m = new JogadorMeio();
                        Console.WriteLine(m.Dados());
                        Console.WriteLine(m.Aposentar());

                        break;
                    default:
                        Console.WriteLine("Opção inválida, selecione uma opção válida");
                        opcaoValida = false;
                        break;
                }
            } while (!opcaoValida);
        }
    }
}

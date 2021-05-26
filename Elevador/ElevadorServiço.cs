using System;

namespace Elevador
{
    public class ElevadorServiço : Elevador
    {
        public void FazerServico()
        {
            bool opcaoValidaElevador = true;
            do
            {
                Console.WriteLine(@"
    Você deseja:
    1 - Entrar no elevador
    2 - Sair do elevador
    3 - Subir
    4 - Descer 
    5 - Mexer nas caixas  
    6 - Sair do sistema
            ");
                int opcaoFazerDentro = int.Parse(Console.ReadLine());

                switch (opcaoFazerDentro)
                {
                    case 1:
                        Entrar();
                        opcaoValidaElevador = false;
                        break;
                    case 2:
                        Sair();
                        opcaoValidaElevador = false;
                        break;
                    case 3:
                        Subir();
                        opcaoValidaElevador = false;
                        break;
                    case 4:
                        Descer();
                        opcaoValidaElevador = false;
                        break;
                    case 5:
                        NumeroCaixas();
                        opcaoValidaElevador = false;
                        break;
                    case 6:
                        Console.WriteLine("Até mais");
                        opcaoValidaElevador = true;
                        break;
                    default:
                        Console.WriteLine("\nSelecione uma opção válida");
                        opcaoValidaElevador = false;
                        break;
                }
            } while (!opcaoValidaElevador);
        }

        public int caixas = 0;
        public void NumeroCaixas()
        {
            bool opcaoValidaElevadorServico = true;

            do
            {
                Console.WriteLine("Cabem 10 caixar no elevador!!!");


                if (caixas >= 0)
                {
                    int contaCaixa;
                    do
                    {
                        Console.WriteLine($@"
Você deseja adicionar ou remover?
    1 - Adicionar
    2 - Remover 
    3 - Sair do sistema das caixas
            ");
                        int opcao = int.Parse(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                if (caixas < 10 && caixas >= 0)
                                {
                                    Console.WriteLine($"O elevador tem {caixas} caixas\n");
                                    Console.WriteLine("Você deseja adicionar quantas caixas?");
                                    contaCaixa = int.Parse(Console.ReadLine());
                                    if (caixas + contaCaixa <= 10)
                                    {
                                        Console.WriteLine($"O elevador agora tem {caixas + contaCaixa} caixas");
                                        caixas = caixas + contaCaixa;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Impossível colocar essa quantidade de caixas");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Impossível colocar mais caixar");
                                }
                                break;
                            case 2:
                                if (caixas <= 10 && caixas >= 0)
                                {
                                    Console.WriteLine($"O elevador tem {caixas} caixas\n");
                                    Console.WriteLine("Você deseja remover quantas caixas?");
                                    contaCaixa = int.Parse(Console.ReadLine());

                                    if (caixas - contaCaixa >= 0)
                                    {
                                        Console.WriteLine($"O elevador agora tem {caixas - contaCaixa} caixas");
                                        caixas = caixas - contaCaixa;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Impossível remover essa quantidade de caixas");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Não é possível remover mais caixas");
                                }
                                break;
                            case 3:
                                opcaoValidaElevadorServico = false;
                                Console.WriteLine("Até mais");
                                break;
                            default:
                                Console.WriteLine("Selecione uma opção valida");
                                break;
                        }
                    } while (opcaoValidaElevadorServico);
                }
                else if (caixas < 0)
                {
                    Console.WriteLine("Digite um número valido");
                }

            } while (caixas < 0);
        }
    }
}
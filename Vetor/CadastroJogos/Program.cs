using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroJogos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARAR O VETOR DE NOMES DE JOGOS
            string[] vetJogos = new string[3];

            do
            {


                //MENU
                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

░░░░░██╗░█████╗░░██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░╚═════╝░");

                Console.WriteLine("1 - Cadastrar");
                Console.WriteLine("2 - Consultar");
                Console.WriteLine("3 - Atualizar");
                Console.WriteLine("4 - Excluir");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    //CADASTRAR NOME NO VETOR
                    for (int i = 0; i < vetJogos.Length; i++)
                    {
                        Console.WriteLine($"Informe o {i + 1}º nome do jogo: ");
                        vetJogos[i] = Console.ReadLine();
                    }

                    Console.WriteLine("Para continuar, pressione a tecla Enter");
                    Console.ReadKey();

                }
                else if (opcao == 2)
                {
                    //CONSULTAR OS VALORES DO VETOR
                    for (int i = 0; i < vetJogos.Length; i++)
                    {
                        Console.WriteLine($"Posição: {i} | Nome do jogo: {vetJogos[i]}");
                    }

                    Console.WriteLine("Para continuar, pressione a tecla Enter");
                    Console.ReadKey();
                }
                else if (opcao == 3)
                {
                    //IMPLEMENTAR A FUNÇÃO DE ATUALIZAR
                    //SOLICITAR O ÍNDICE E O NOVO NOME
                    //ALTERAR O NOME NO VETOR
                }
                else if (opcao == 4)
                {
                    //IMPLEMENTAR A FUNÇÃO DE EXCLUIR
                    //SOLICITAR O ÍNDICE DO NOME DO JOGO PARA O USUÁRIO
                    //ATRIBUIR UM VALOR " " PARA EXCLUIR
                }
                Console.Clear();

            } while (true);

        }
    }
}

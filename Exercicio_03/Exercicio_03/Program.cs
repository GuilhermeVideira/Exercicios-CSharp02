using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Program
    {
        public struct Carro
        { 
           public string placa;
           public string modelo;
           public int ano; 
           public string cor;
        }

    static void Main(string[] args)
    {

            const int TAM = 500;
            Carro[] c = new Carro[TAM];
            int op;
            bool sair = false;
            while (sair == false)
            {
                Console.Clear();
                Console.WriteLine("1 - Cadastrar Carro");
                Console.WriteLine("2 - Consultar Carro por Ano de Fabricação");
                Console.WriteLine("3 - Consultar Carro por Modelo");
                Console.WriteLine("4 - Consultar Carro por Cor");
                Console.WriteLine("5 - Exibir todos os carros cadastrados");
                Console.WriteLine("6 - Alterar algum dado de um carro");
                Console.WriteLine("7 - Excluir um carro");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção: ");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        cadastraCarro(c);
                        break;
                    case 2:
                        consultaCarroAnoFab(c);
                        break;
                    case 3:
                        consultaCarroModelo(c);
                        break;
                    case 4:
                        consultaCarroCor(c);
                        break;
                    case 5:
                        exibirTodosCarrosCadastrados(c);
                        break;
                    case 6:
                        alterarCarro(c);
                        break;
                    case 7:
                        excluirCarro(c);
                        break;
                    case 0:
                        Console.Write("\nPressione qualquer tecla para sair...");
                        Console.ReadKey();
                        sair = true;
                        break;
                }
            }
        }

        //Metódos --->

        static void excluirCarro(Carro[] c)
        {
            string placa;
            const int TAM = 500;
            Console.Clear();
            Console.WriteLine("***** Consulta por cor do veículo *****\n");
            Console.Write("Informe a cor desejada: ");
            placa = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < TAM; i++)
            {
                Console.WriteLine("Placa / Modelo / Ano / Cor");
                if (c[i].placa == placa)
                {
                    c[i].placa = "";
                    c[i].modelo = "";
                    c[i].ano = 0;
                    c[i].cor = "";
                    Console.WriteLine("Veículo excluído!");
                }
            }
            Console.Write("\nPressioneEnter para retornar ao menu principal");
            Console.ReadKey();
        }



        static void consultaCarroCor(Carro[] c)
        {
            string cor;
            const int TAM = 500;
            Console.Clear();
            Console.WriteLine("***** Consulta por cor do veículo *****\n");
            Console.Write("Informe a cor desejada: ");
            cor = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i < TAM; i++)
            {
                Console.WriteLine("Placa / Modelo / Ano / Cor");
                if (c[i].cor == cor)
                {
                    Console.WriteLine(c[i].placa + " " + c[i].modelo + " " + (c[i].ano).ToString() + " " + c[i].modelo);
                }
            }
            Console.Write("\nPressioneEnter para retornar ao menu principal");
            Console.ReadKey();
        }



        static void alterarCarro(Carro[] c)
        {
            const int TAM = 500;
            string placa;
            int op;
            Console.Clear();
            Console.Write("Informe a placa do carro (formato AAA9999): ");
            placa = Console.ReadLine();
            for (int i = 0; i < TAM; i++)
            {
                if (c[i].placa == placa)
                {
                    Console.WriteLine(c[i].modelo + " " + (c[i].ano).ToString() + " " + c[i].cor);
                    Console.Write("Qual dado do veículo deseja alterar (1 - placa, 2 - modelo, 3 - cor, 4 - ano de fabricação)? ");
                    op = int.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.Write("Nova placa? ");
                            c[i].placa = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Novo modelo? ");
                            c[i].modelo = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Nova cor? ");
                            c[i].cor = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("Novo ano de fabricação? ");
                            c[i].ano = int.Parse(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("Opçãoinválida");
                            break;
                    }
                    break;
                }
                else
                    Console.WriteLine("Placa não encontrada\n");
            }
            Console.Write("\nPressioneEnter para retornar ao menu principal");
            Console.ReadKey();
        }



        static void exibirTodosCarrosCadastrados(Carro[] c)
        {
            const int TAM = 500;
            Console.Clear();
            Console.WriteLine("Placa / Modelo / Ano / Cor");
            for (int i = 0; i < TAM; i++)
            {
                Console.WriteLine(c[i].placa + " " + c[i].modelo + " " + (c[i].ano).ToString() + " " + c[i].cor);
            }
            Console.Write("\nPressioneEnter para retornar ao menu principal");
            Console.ReadKey();
        }



        static void consultaCarroModelo(Carro[] c)
        {
            string modelo;
            const int TAM = 500;
            Console.Clear();
            Console.WriteLine("***** Consulta por ano de fabricação *****\n");
            Console.Write("Informe o modelo desejado: ");
            modelo = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Modelo / Ano / Cor");
            for (int i = 0; i < TAM; i++)
            {
                if (c[i].modelo == modelo)
                {
                    Console.WriteLine(c[i].placa + " " + c[i].modelo + " " + (c[i].ano).ToString() + " " + c[i].cor);
                }
            }
            Console.Write("\nPressioneEnter para retornar ao menu principal");
            Console.ReadKey();
        }



        static void consultaCarroAnoFab(Carro[] c)
        {
            int ano;
            const int TAM = 500;
            Console.Clear();
            Console.WriteLine("***** Consulta por ano de fabricação *****\n");
            Console.Write("Informe o ano desejado com 4 dígitos: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i < TAM; i++)
            {
                Console.WriteLine("Placa / Modelo / Ano / Cor");
                if (c[i].ano == ano)
                {
                    Console.WriteLine(c[i].placa + " " + c[i].modelo + " " + (c[i].ano).ToString() + " " + c[i].modelo);
                }
            }
            Console.Write("\nPressioneEnter para retornar ao menu principal");
            Console.ReadKey();
        }



        static void cadastraCarro(Carro[] c)
        {
            const int TAM = 500;
            Console.Clear();
            Console.WriteLine("***** Cadastramento de Carro *****\n");
            for (int i = 0; i < TAM; i++)
            {
                Console.Write("Qual é a placa do carro? ");
                c[i].placa = Console.ReadLine();
                Console.Write("Qual o modelo do carro? ");
                c[i].modelo = Console.ReadLine();
                Console.Write("Qual o ano do carro? ");
                c[i].ano = int.Parse(Console.ReadLine());
                Console.Write("Qual é a cor do carro? ");
                c[i].cor = Console.ReadLine();
            }
            Console.Write("\nPressioneEnter para retornar ao menu principal");
            Console.ReadKey();
        }
    }
}


    
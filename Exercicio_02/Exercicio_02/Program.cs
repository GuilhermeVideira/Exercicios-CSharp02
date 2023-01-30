using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Program
    {

        public struct cadaluno
        { 
        public string nome;
        public float nota1;
        public float nota2;
        public float media;
        public string situacao;
        }

       public static cadaluno[] aluno = new cadaluno[15];

        static void Main(string[] args)
        {
            int q;
            char sair = 'b';
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (sair != 'S' && sair != 's')
            {
                Console.Clear();
            retorno:
                Console.WriteLine(" Cadastro de Aluno");
                Console.WriteLine(" digite a quantidade de alunos a serem cadastrado de 1 ate 15");
                q = int.Parse(Console.ReadLine());
                if (q < 1 || q > 15)
                {
                    Console.WriteLine(" o intervalo esta invalido ");
                    goto retorno;
                }
                entrada(q);
                Console.WriteLine(" Resultado do cadastro ");
                relatorio(q);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" Dejesa sair S/N");
                sair = char.Parse(Console.ReadLine());
            }
            Console.ReadKey();
        }

        //Metódos
        static void entrada(int quant)
        {
            int x, mos = 0;
            string nome;
            float nota,media;
            for (x = 0; x < quant; x++)
            {
                mos = x + 1;
                Console.WriteLine(mos + " º Nome do aluno =");
                nome = Console.ReadLine();
                aluno[x].nome = nome;
                retornon1:
                Console.WriteLine("1 º nota =");
                nota = float.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine(" A primeira nota esta invalida 0 até 10 ");
                    goto retornon1;
                }
                aluno[x].nota1 = nota;
                retornon2:
                Console.WriteLine("2 º nota =");
                nota = float.Parse(Console.ReadLine());
                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine(" A segunda nota esta invalida 0 até 10 ");
                    goto retornon2;
                }
                aluno[x].nota2 = nota;
                media = (aluno[x].nota1 + aluno[x].nota2) / 2;
                aluno[x].media = media;
                if (media >= 7)
                    aluno[x].situacao = "Aprovado";
                else
                    aluno[x].situacao = "Reprovado";
            }
        }

        static void relatorio(int quant)
        {
            int x;
            Console.Clear();
            for (x = 0; x < quant; x++)
            {
                if (aluno[x].situacao == "Aprovado")
                    Console.ForegroundColor = ConsoleColor.Blue;
                else
                    Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(aluno[x].nome + " \t " + aluno[x].nota1 + " \t " + aluno[x].nota2 + " \t " + aluno[x].media + "\t " + aluno[x].situacao);
            }


        }
    }
}

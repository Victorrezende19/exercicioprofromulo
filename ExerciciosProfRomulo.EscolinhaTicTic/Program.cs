using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosProfRomulo.EscolinhaTicTic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Exercício 4- Crie um programa para a escolinha Tic Tic
            calcular 3 notas de um aluno.
            Entrar com o nome do aluno e as três notas
            Mostrar a soma das notas e a média.
            */


            double num1, num2, num3; 
            double media;
            string nome;
            Console.WriteLine("digite as 3 notas: ");
            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());
            num3 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o seu nome: ");
            nome = (Console.ReadLine());
            media = (num1 + num2 + num3) / 3;
            Console.WriteLine($"Olá {nome} a media das suas notas é {media} suas notas foram {num1},{num2} e {num3}");
            if (media <= 7)
            {
                Console.WriteLine($"O aluno {nome},esta reprovado!" );
              }
            else
            {
                Console.WriteLine($"O aluno {nome} esta aprovado com a nota {media}! Parabens!");
            }
            Console.ReadKey();


        }
    }
}

using System;

namespace PontuaçãoSeESenão
{
    class Program
    {
        static void Main(string[] args)
        {
            int pontos = 0;
            int resposta;

            Console.WriteLine("  Perguntas sobre heróis  ");
            Console.WriteLine("");

            Console.WriteLine("A) Qual o herói cujo nome é Tony Stark?");
            Console.WriteLine("1)Capitão América");
            Console.WriteLine("2)Homem de Ferro");
            Console.WriteLine("3)Gavião Arqueiro");

            resposta = Convert.ToInt16(Console.ReadLine());

            if (resposta == 2)

            {
                pontos = pontos + 10;
                Console.WriteLine("Sua resposta foi: 2)Homem de Ferro");
                Console.WriteLine("Resposta Correta!");
                Console.WriteLine("Pontuação: " + pontos);
            }

            else
            {
                Console.WriteLine("Sua resposta foi:" + resposta);
                Console.WriteLine("Resposta Errada!");
                Console.WriteLine("Pontuação:" + pontos);
            }


           Console.WriteLine(""); 



            Console.WriteLine("B) Qual é o filme no qual Thanos ganha a luta?");
            Console.WriteLine("1)Vingadores");
            Console.WriteLine("2)Vingadores - Era de Ultron");
            Console.WriteLine("3)Vingadores - Guerra Infinita");

            resposta = Convert.ToInt16(Console.ReadLine());

            if (resposta == 3)

            {
                pontos = pontos + 10;
                Console.WriteLine("Sua resposta foi: 3)Vingadores - Guerra Infinita");
                Console.WriteLine("Resposta Correta!");
                Console.WriteLine("Pontuação: " + pontos);
            }

            else
            {
                Console.WriteLine("Sua resposta foi:" + resposta);
                Console.WriteLine("Resposta Errada!");
                Console.WriteLine("Pontuação:" + pontos);
            }


            Console.WriteLine("");
        }
    }
}




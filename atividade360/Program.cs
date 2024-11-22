using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade360
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int idade = 0;
            int pontos = 0;
            bool flag = false;

            try
            {
                while (!flag)
                {

                    Console.WriteLine("Digite sua idade ou 'S' para sair: ");
                    string input1 = Console.ReadLine();


                    if (input1.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }

                    try
                    {
                        idade = int.Parse(input1);


                        if (idade < 18 || idade > 75)
                        {
                            Console.WriteLine("Sua idade não é valida");
                            continue;
                        }
                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }
                }

                flag = false;

                while (!flag)
                {


                    Console.WriteLine("Digite sua nota da avaliação 360 ou 'S' para sair: ");
                    string input2 = Console.ReadLine();


                    if (input2.ToUpper() == "S")
                    {
                        Console.WriteLine("Programa encerrado.");
                        return;
                    }

                    try
                    {
                        pontos = int.Parse(input2);


                        if (pontos < 50 || pontos > 100)
                        {
                            Console.WriteLine("Erro: por favor digite um valor valido");
                            continue;
                        }
                        flag = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Erro: Por favor, digite um valor numérico válido.");
                    }
                }


                Console.Clear();

                if (idade <= 25 && pontos >= 80)
                {
                    Console.WriteLine("Subsídio Aprovado, Parabéns.");
                }

                else
                {
                    Console.WriteLine("Subsídio não aprovado");
                }

            }
            finally
            {

            }
            Console.ReadKey();

        }
    }
}

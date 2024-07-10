using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Numero
    {
        public void Programa()
        {
            int num1, num2;
            int escolha;

            Console.WriteLine("Digite o  número inteiro:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número inteiro:");
            num2 = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Verificar se um número é múltiplo do outro");
                Console.WriteLine("2 - Verificar se os dois números são pares");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
                Console.WriteLine("4 - Sair");
                Console.Write("Opção: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        if (num1 % num2 == 0 || num2 % num1 == 0)
                            Console.WriteLine("Um dos números é múltiplo do outro.");
                        else
                            Console.WriteLine("Nenhum dos números é múltiplo do outro.");
                        break;

                    case 2:
                        if (num1 % 2 == 0 && num2 % 2 == 0)
                            Console.WriteLine("Ambos os números são pares.");
                        else
                            Console.WriteLine("Pelo menos um dos números não é par.");
                        break;

                    case 3:
                        double media = (num1 + num2) / 2.0;
                        if (media >= 7)
                            Console.WriteLine($"A média dos números ({media}) é maior ou igual a 7.");
                        else
                            Console.WriteLine($"A média dos números ({media}) é menor que 7.");
                        break;

                    case 4:
                        Console.WriteLine("Programa encerrado.");
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Digite um número de 1 a 4.");
                        break;
                }

            } while (escolha != 4);
        }
    }
}

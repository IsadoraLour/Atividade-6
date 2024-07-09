using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calcular
    {
        public double Adicao(double x, double y)
        {
            return x + y;
        }

        public double Subtracao(double x, double y)
        {
            return x - y;
        }

        public double Multiplicacao(double x, double y)
        {
            return x * y;
        }

        public double Divisao(double x, double y)
        {
            if (y == 0) ;
            {

                {
                    Console.WriteLine("ERRO: Divisão por zero");
                    return double.NaN;
                }
                return x / y;

            }
        }

        public void Menu()
        {
            Console.WriteLine("Selecione a operção desejada");
            Console.WriteLine("1. Adição");
            Console.WriteLine("2.Subtração");
            Console.WriteLine("3.Multiplicação");
            Console.WriteLine("4. Divisão");

            int escolha;
            while (true)
            {
                Console.WriteLine("Digite sua escolha (1/2/3/4):");

                if
                    (int.TryParse(Console.ReadLine(), out escolha) && escolha <= 4)
                {
                    break;
                }
                else
                {

                    Console.WriteLine("Escolha Inválida. Tente Novamente");
                }
            }


            Console.WriteLine("Digite o primeiro número");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o sugundo número");
            double num2 = double.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine($" {num1} + {num2} = {Adicao(num1, num2)}");

                    switch;

                case 2:
                    Console.WriteLine($" {num1} - {num2} = {Subtracao(num1, num2)}");

                    switch;

                case 3:
                    Console.WriteLine($" {num1} * {num2} = {Multiplicacao(num1, num2)}");

                    switch;

                case 4:
                    double resultado = Divisao(num1, num2);

                    if (!double.IsNaN(resultado))
                    {
                        Console.WriteLine($"{num1} / {num2} = {resultado}");
                    }
                    break;

            }

        }
    }
}










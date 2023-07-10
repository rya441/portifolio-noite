using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora"; // cria um titulo para o projeto
            Console.WriteLine("--------------------Calculadora--------------------"); // o que vai aparecer na tela do programa

            double valor1 = 0, valor2 = 0, resultado, numero; // usando double para ter mais precisão nas casas depois da virgula (64 bits), atribuindo 0 aos valores
            string operador, valorDigitado;
            bool numero_inteiro;

            Console.WriteLine("Digite o primeiro valor, depois aperte enter: ");
            valorDigitado = Console.ReadLine();

            /*Essa linha vai verificar se é um número inteiro, se for igual a variavel numero_inteiro será 1 ou true, se não 0 ou false, 
             * também precisaremos fazer a conversão, poderia usar o Parse mas nesse caso usei o TryParse pois, 
             * ele não lança uma exceção se a conversão falhar.*/
            numero_inteiro = double.TryParse(valorDigitado, out numero);

            //Começamos nossa condicional para fazer a validação, 
            if (numero_inteiro)
            {
                valor1 = Math.Round(double.Parse(valorDigitado), 3);//tendo essa validação vamos precisar armazenar o valor1 apenas se for true
                /*Para armazenar vamos usar o método Round da classe Math, aquele que arredonda os valores
                 * então o número 3 alí significa que vou considerar apenas 3 casas apos a vírgula, lembrando que o valor digitado em string
                 * já esta sendo convertido para double.*/
            }
            else
            {
                Console.WriteLine("Digite um número válidoe aperte enter:");
            }

            Console.WriteLine("Digite a operação matemática desejada: ( /= divisão , * = multiplicação, + = soma, - = subtração e % = MOD resto ): ");
            operador = Console.ReadLine();

            //SEGUNDA ETAPA
            /*É a repetição da primeira etapa com a diferença de que vamos armazenar o segundo valor digitado na variavél valor2
             a validação e a estrutura de decição permanece a mesma*/

            Console.WriteLine("Digite o segundo valor: ");
            valorDigitado = Console.ReadLine();
            numero_inteiro = double.TryParse(valorDigitado, out numero);
            if (numero_inteiro)
            {
                valor2 = Math.Round(double.Parse(valorDigitado), 3);
            }
            else
            {
                Console.WriteLine("Digite um número válido aperte enter:");
            }

            switch (operador)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 3);
                    Console.WriteLine($"{valor1} {'+'} {valor2} = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 3);
                    Console.WriteLine($"{valor1} {'-'} {valor2} = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 3);
                    Console.WriteLine($"{valor1} {'*'} {valor2} = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 3);
                    Console.WriteLine($"{valor1} {'/'} {valor2} = {resultado}");
                    break;
                case "%":
                    resultado = Math.Round(valor1 % valor2, 3);
                    Console.WriteLine($"{valor1} {'%'} {valor2} = {resultado}");
                    break;
                default:
                    Console.WriteLine("Digite uma operação válida");
                    break;
            }

            Console.ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace projetoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("CALCULADORA");
            Console.WriteLine("------------");
            Console.WriteLine("Selecione uma das opçôes:");
            int escolha;
            do
            {
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");
                escolha = int.Parse( Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Sub();
                        break;
                    case 3:
                        Div();
                        break;
                    case 4:
                        Mul();
                        break;
                    case 5:
                        Pot();
                        break;
                    case 6:
                        Raiz();
                        break;
                    case 7:
                        Console.WriteLine("Saindo da calculadora...");
                        Console.WriteLine("Pressione ENTER para sair");
                        Console.ReadLine();
                        break;
                }
                Console.Clear();
            } while(escolha!=7);
        }
        static void Soma()
        {
            Console.WriteLine("Somar");
            Console.WriteLine("Insira o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o segundo número:");
            int n2 = int.Parse(Console.ReadLine()) ;
            int res = n1 + n2;
            Console.WriteLine("A soma de "+n1+" + "+n2+" = "+res);
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Subtrair");
            Console.WriteLine("Digite o primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int res = n1 - n2;
            Console.WriteLine("O resultado de "+n1+" - "+n2+" = "+res);
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Dividir");
            Console.WriteLine("Digite o Primeiro número:");
            float n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo número:");
            float n2 = float.Parse(Console.ReadLine());
            float res = n1 / n2;
            Console.WriteLine("O resultado de " + n1 + " % " + n2 + " = " + res);
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }
        static void Mul()
        {
            Console.WriteLine("Multiplicar");
            Console.WriteLine("Digite o Primeiro número:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Segundo número:");
            int n2 = int.Parse(Console.ReadLine());
            int res = n1 * n2;
            Console.WriteLine("O resultado de " + n1 + " X " + n2 + " = " + res);
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }
        static void Pot()
        {
            Console.WriteLine("Potênciação");
            Console.WriteLine("Digite a base:");
            int bas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente:");
            int exp = int.Parse(Console.ReadLine());
            double res = Math.Pow( bas,exp);
            Console.WriteLine("O Resultado de "+bas+" ^ "+exp+" = "+res);
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine() ;
        }
        static void Raiz()
        {
            Console.WriteLine("Raiz Quadrada");
            Console.WriteLine("Digite um número:");
            double raiz = double.Parse(Console.ReadLine());
            double res = Math.Sqrt(raiz);
            Console.WriteLine("A Raiz quadeada de "+raiz+" é "+res);
            Console.WriteLine("Aperte ENTER para voltar para o MENU");
            Console.ReadLine();
        }

    }
}

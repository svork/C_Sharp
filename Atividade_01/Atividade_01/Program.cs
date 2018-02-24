using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01
{
    class Program
    {
        static void Main(string[] args)
        {

            Pessoa Jailson = new Pessoa();

            String peso;
            String altura;

            Console.WriteLine("-------- Leitura de Dados Pessoa 1-------");

            Console.Write("Digite seu nome: ");

            Jailson.nome=Console.ReadLine();

            Console.Write("Digite sua altura: ");

            peso = Console.ReadLine();

            Jailson.peso=Convert.ToDouble(peso);

            Console.Write("Digite seu peso: ");
            

            altura = Console.ReadLine();

            Jailson.altura = Convert.ToDouble(altura);

            Console.WriteLine("_________________________________________\n");

            //-----------------------------

            Pessoa Jailson2 = new Pessoa();

            String peso2;
            String altura2;

            Console.WriteLine("-------- Leitura de Dados Pessoa 2-------");

            Console.Write("Digite seu nome: ");

            Jailson2.nome = Console.ReadLine();

            Console.Write("Digite sua altura: ");

            peso2 = Console.ReadLine();

            Jailson2.peso = Convert.ToDouble(peso);

            Console.Write("Digite seu peso: ");
            

            altura2 = Console.ReadLine();

            Jailson2.altura = Convert.ToDouble(altura);

            Console.WriteLine("_________________________________________\n");
            
            //-----------------------------

            Pessoa Jailson3 = new Pessoa();

            String peso3;
            String altura3;

            Console.WriteLine("-------- Leitura de Dados Pessoa 3-------");

            Console.Write("Digite seu nome: ");

            Jailson3.nome = Console.ReadLine();

            Console.Write("Digite sua altura: ");

            peso3 = Console.ReadLine();

            Jailson3.peso = Convert.ToDouble(peso);

            Console.Write("Digite seu peso: ");
            

            altura3 = Console.ReadLine();

            Jailson3.altura = Convert.ToDouble(altura);

            Console.WriteLine("_________________________________________\n");

            //-----------------------------

            Console.Clear();

            Console.WriteLine("______________Pessoa 1_______________\n");
            Jailson.fale_sobre_vc();

            Console.WriteLine("______________Pessoa 2_______________\n");
            Jailson2.fale_sobre_vc();

            Console.WriteLine("______________Pessoa 3_______________\n");
            Jailson3.fale_sobre_vc();

            Console.ReadKey();
        }
    }
}

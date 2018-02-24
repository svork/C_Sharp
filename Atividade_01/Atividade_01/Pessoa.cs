using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_01
{
    class Pessoa{
        // Atributes
        public String nome;
        public double altura;
        public double peso;

        // Methods
        public void fale_sobre_vc(){

            Console.WriteLine("Seu nome é: " + nome );
            Console.WriteLine("Sua altura é: " + altura + " cm");
            Console.WriteLine("Seu peso é: " + peso + " kg");

            Console.WriteLine("\n");
            
        }
    }
}

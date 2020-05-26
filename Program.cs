using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            int salario;
            string sexo;
            string estadoCivil;

            Console.Write("Digite o nome: ");
            nome = Console.ReadLine();
            Console.Clear();

            Console.Write("Digite a idade: ");
            idade =Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Digite o salario: ");
            salario = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.Write("Qual o sexo: ");
            sexo = Console.ReadLine();
            sexo = ObterFouM(sexo);
            Console.Clear();

            Console.Write("Digite o estado civil: ");
            estadoCivil = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Os dados: \n nome: " + nome + "\n Idade: " + idade +
                "\n Salario: " + salario + "\n sexo: " + sexo + "\n Estado Civil: " + estadoCivil);

            Console.ReadLine();
        }
        public static string ObterFouM(string sexo)
        {
            while  (!(sexo == "f" || sexo == "m"))
            {
                Console.Write("digite apenas as inicias 'f' ou 'm'\n");
                Console.Write("Digite novamente: ");
                sexo = Console.ReadLine();
              
            }
            return sexo;
        }
    }
}

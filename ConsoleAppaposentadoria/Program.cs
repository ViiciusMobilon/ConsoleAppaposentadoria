using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppaposentadoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o sua idade:");
           int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu tempo de serviso");
            int idades = int.Parse(Console.ReadLine());

            if (idade >= 65 || idades >= 30 || idade >= 60 && idades >= 25)
            {
                Console.WriteLine("Você se aposentou ");
                Console.ReadKey();
            }
           
            else { Console.WriteLine("Você aida não pode se aposentar");
                Console.ReadKey();
            }
        }
    }
}

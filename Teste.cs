using System;

namespace console_dotnet
{
    class Teste{

        public bool teste1() {

            Random rdm = new Random();

            int N1 = rdm.Next(10);
            int N2 = rdm.Next(10);
            int Total = N2 + N1;
            Console.WriteLine("O primeiro número sorteado: " + N1);
            Console.WriteLine("O segundo número sorteado: " + N2);

            Console.WriteLine("Qual a soma dos dois número sorteados? ");
            int Read = Convert.ToInt32(Console.ReadLine());

            if(Read == Total){

                Console.WriteLine("Acesso Permitido");
                return true;

            }else{

                Console.WriteLine("Acesso negado");
                return false; 
            }
        }
    }
}
using System;

namespace console_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Daniel";
            Console.WriteLine("Hi " + name);

            Double valor = 70.7;
            Double quantidade =7.70;
            Double forgiveness = valor * quantidade;
            Console.WriteLine($"seu cálculo: {valor} * {quantidade}; é igual a: " + forgiveness);

            Boolean maiorQueDez = valor > 10;
            if(maiorQueDez){
                //1ºManeira de escrita
                Console.WriteLine($"E adivinha... \n {forgiveness} é maior que dez!! :D");
            }else{
                //2°Maneira de escrita
                Console.WriteLine("E adivinha... \n {0} é menor que dez!! D:", forgiveness);
            }
                Identidade i = new Identidade();
                i.numero = 10;

                Boolean numeroIdentidade = i.numero < 10;
                if(numeroIdentidade){
                    name = "Paulo";
                    Console.WriteLine("Seu nome é: " + name);
                }else{

                    name = "Sem identidade";
                    Console.WriteLine("Você não tem nome: " + name);
                }

                int N1;
                int N2;
                
                Random rdm = new Random();

                N1 = rdm.Next(20);
                N2 = rdm.Next(20);
                Console.WriteLine("O Número sorteado: " + (N1 + N2));
                

        }

    }

}
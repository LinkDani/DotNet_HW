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
 
        }
    }
}

using System.Globalization;

namespace DesafioBar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bill conta = new Bill();
            
            Console.Write("Sexo: ");
            conta.Gender = char.Parse(Console.ReadLine());
            
            Console.Write("Quantidade de cervejas: ");
            conta.Beer = int.Parse(Console.ReadLine());
                        
            Console.Write("Quantidade de refrigerantes: ");
            conta.SoftDrink = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de espetinhos: ");
            conta.Barbecue = int.Parse(Console.ReadLine());


            Console.WriteLine("\nRelatório: ");
            Console.WriteLine("Consumo = R$ " + conta.Feeding().ToString("F2",CultureInfo.InvariantCulture));
            
            if (conta.Cover() > 0)
            {
                Console.WriteLine("Covert = R$ " + conta.Cover().ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Isento de couvert!");
            }    
                
            Console.WriteLine("Ingresso = R$ " + conta.Ticket().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("\nValor a pagar = R$ " + conta.Total().ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}

using System.Reflection;
using Veículos.Entidades.Carros;
using Veículos.Entidades.Motos;
using Veículos.Entidades.Serviços;

namespace Veículos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Seguro sStrada = new Seguro();
            Seguro sHrv = new Seguro();
            Picape picapeStrada = new Picape();
            Sedan sedanHrv = new Sedan();
           
            Carro hrv = new Carro(4, 4, null, sedanHrv, sStrada );
            Carro strada = new Carro(2, 2, picapeStrada, null, sHrv);


            Console.WriteLine("Caracteristicas do HRV:");
            hrv.mostrar();

            Console.WriteLine("Caracteristicas da Srada");
            strada.mostrar();

            Motocross mKawasaki = new Motocross();
            Scooter sBiz = new Scooter();
            Moto kawasaki = new Moto(mKawasaki, null, true);
            Moto biz = new Moto(null, sBiz,true);

            // Exibindo detalhes das motos
            Console.WriteLine("Caracteristicas da Kawasaki");
            kawasaki.mostrar();

            Console.WriteLine("Caracteristicas da Biz:");
            biz.mostrar();
        }
    }
}

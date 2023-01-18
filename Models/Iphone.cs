using System.Xml;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo" #feito
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo {aplicativo} no Iphone");
        }
    }
}
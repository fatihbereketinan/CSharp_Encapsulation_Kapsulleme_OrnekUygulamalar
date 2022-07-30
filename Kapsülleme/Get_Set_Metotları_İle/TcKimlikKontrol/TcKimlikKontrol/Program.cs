using System;

namespace TcKimlikKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel();

            personel1.setTC("12345678900");
            Console.WriteLine("TC Kimlik Numaranız: " + personel1.getTC());
        }
    }
}

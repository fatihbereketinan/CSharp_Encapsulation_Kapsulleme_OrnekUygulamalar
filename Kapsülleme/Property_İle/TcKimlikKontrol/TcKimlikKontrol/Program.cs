using System;

namespace TcKimlikKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel();
            personel1._tckimlikno = "123456789"; //11 haneli olmayan. 
            Console.WriteLine("TC Kimlik Numaranız: "+personel1._tckimlikno);
        }
    }
}

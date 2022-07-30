using System;
using System.Collections.Generic;
using System.Text;

namespace TcKimlikKontrol
{
    public class Personel
    {
        private string tckimlikno;

        public string getTC()
        {
            return tckimlikno.Substring(0,5)+"******";
        }
        public void setTC(string _tckimlikno)
        {
            bool kontrol = true;
            if (_tckimlikno.Length==11)
            {
                for (int i = 0; i < _tckimlikno.Length; i++)
                {
                    bool sayiMi = char.IsNumber(_tckimlikno[i]);

                    if (sayiMi==true)
                    {

                    }
                    else
                    {
                        kontrol = false;
                    }
                }
                if (kontrol==false)
                {
                    Console.WriteLine("TC kimlik numaranızda geçersiz karekter bulundu.");
                }
                else
                {
                    tckimlikno = _tckimlikno;
                }
            }
            else
            {
                Console.WriteLine("TC kimlik numaranız 11 karekter olmalıdır !!!");
            }
        }
    }
}

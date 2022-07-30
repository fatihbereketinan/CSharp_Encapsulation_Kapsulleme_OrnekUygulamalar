using System;
using System.Collections.Generic;
using System.Text;

namespace TcKimlikKontrol
{
    class Personel
    {
        private string tckimlikno;
        public string _tckimlikno
        {
            get
            {
                return tckimlikno.Substring(0, 5) + "******";
            }
            set
            {
                bool kontrol = false;
                if (value.Length==11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if (sayiMi)
                        {

                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }
                    if (kontrol)
                    {
                        Console.WriteLine("TC kimlik numaranızda geçersiz karekter bulundu.");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                }
                else
                {
                    Console.WriteLine("TC kimlik numaranız 11 karekter olmalıdır !!!");
                }
            }
        }
    }
}

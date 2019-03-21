using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaasHesaplama
{
    static class Hesapla
    {
        
        public static string BrutMaas(string[] personelBilgi)
        {
            // brut maas hesaplama kismi
            //brut maas = taban maaş+ makam tazminatı + idari görev +  çocuk sayış X 30 
            //+ fazla mesai saati X fazla mesai ücreti
            float brutMaas = 0;

            brutMaas += Convert.ToInt32(personelBilgi[8]);
            brutMaas += Convert.ToInt32(personelBilgi[9]);
            brutMaas += Convert.ToInt32(personelBilgi[10]);
            brutMaas += Convert.ToInt32(personelBilgi[7]) * 30;
            brutMaas += Convert.ToInt32(personelBilgi[11]) * Convert.ToInt32(personelBilgi[12]);

            if (personelBilgi[5] == "E" && personelBilgi[6] == "H")
                brutMaas += 200; // eş yardimi

            
            return Convert.ToString(brutMaas);
        }

        public static string DamgaVergisi(string _brutMaas)
        {
            // damga vergisi hesaplama
            // damga vergisi = (brutMaas * 10) / 100
            float damgaVergisi = 0;
            float brutMaas = Convert.ToInt32(_brutMaas);
            damgaVergisi = ((brutMaas) * 10) / 100;

            return Convert.ToString(damgaVergisi);
        }

        public static string GelirVergisi(string _brutMaas, string _vergiMatrahi)
        {
            /*
            Eğer gelir matrahı  10000 TL den küçük ise  gelir vergisi= Bürüt maaş x 15/100
            Eğer gelir matrahı  10000 TL den büyük eşit ve 20000 TL küçük ise  gelir vergisi= Bürüt maaş x 20/100
            Eğer gelir matrahı  20000 TL den büyük eşit ve 30000 TL küçük ise  gelir vergisi= Bürüt maaş x 25/100
            Eğer gelir matrahı  30000 TL den büyük eşit ise  gelir vergisi= Bürüt maaş x 30/100

             */
            float gelirVergisi = 0;
            float vergiMatrahi = Convert.ToInt32(_vergiMatrahi);
            float brutMaas = Convert.ToInt32(_brutMaas);

            if (vergiMatrahi < 10000)
                gelirVergisi = (brutMaas * 15) / 100;
            else if (vergiMatrahi < 20000)
                gelirVergisi = (brutMaas * 20) / 100;
            else if (vergiMatrahi < 30000)
                gelirVergisi = (brutMaas * 25) / 100;
            else
                gelirVergisi = (brutMaas * 30) / 100;

            return Convert.ToString(gelirVergisi);
        }

        public static string EmekliKesintisi(string _brutMaas)
        {
            // Emekli kesintisi= Bürüt maas x 15/100

            float emekliKesintisi = 0;
            float brutMaas = Convert.ToInt32(_brutMaas);

            emekliKesintisi = (brutMaas * 15) / 100;

            return Convert.ToString(emekliKesintisi);
        }

        public static string NetMaas(string _brutMaas, string _emekliKesintisi, 
                                    string _gelirVergisi, string _damgaVergisi)
        {
            // Net maaş= bürüt maaş-(emekli kesintisi + gelir vergisi + damga vergisi)

            float netMaas = 0;
            float brutMaas = Convert.ToInt32(_brutMaas);
            float emekliKesintisi = Convert.ToInt32(_emekliKesintisi);
            float gelirVergisi = Convert.ToInt32(_gelirVergisi);
            float damgaVergisi = Convert.ToInt32(_damgaVergisi);

            netMaas = brutMaas - (emekliKesintisi + gelirVergisi + damgaVergisi);

            return Convert.ToString(netMaas);
        }
    }
}

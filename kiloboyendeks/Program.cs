using System;

namespace kiloboyendeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
            double indeksHesapla()
            {
                string kiloStr;
                Console.Write("Kilonuzu Giriniz: ");
                kiloStr = Console.ReadLine();

                int kilo = Int32.Parse(kiloStr);

                Console.WriteLine("Kilonuz : " + kilo);

                string boyStr;
                Console.WriteLine("Boyunuzu Giriniz: ");
                boyStr = Console.ReadLine();

                double boy = Convert.ToDouble(boyStr);
                Console.WriteLine("Boyunuz : " + boy);

                double result = (kilo) / (boy * boy);
    

                return result;
            }

            double indeks =  indeksHesapla();
            Console.WriteLine("BMI niz :" + indeks);
            Aralik(indeks);

            void Aralik(double indeks)
            {
                if (indeks >= 45)
                {
                    Console.WriteLine("Aşırı şişmansın AYI!");
                }
                else if (indeks <=44.9 && indeks >= 35)
                {
                    Console.WriteLine("Hala şişmansın davar az kilo ver");
                }
                else if (indeks <=34.9 && indeks >= 30)
                {
                    Console.WriteLine("Biraz daha kilo vermen lazım hala dana gibisin");
                }
                else if (indeks <= 29.9 && indeks >= 25)
                {
                    Console.WriteLine("Fazla kilolusun ama bence sıkıntı yok :)");
                }
                else if (indeks <=24.9 && indeks >= 18.5)
                {
                    Console.WriteLine("Normalsin kanka kasma");
                }
                else if (indeks <=18.4)
                {
                    Console.WriteLine("Zayıfsın az kilo al");
                }

                

                
                
            }
        }
    }
}

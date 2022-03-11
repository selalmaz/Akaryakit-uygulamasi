using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakit_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            double dfiyat = 1.47, bfiyat = 2.38, lfiyat = 1.13;
            double dtank = 1000, btank = 1000, ltank = 1000;
            int secim1, secim2, secim3;
            double miktar = 0.0, ciro = 0.0;
            double dmiktar = 0.0, bmiktar = 0.0, lmiktar = 0.0;
        anamenu:
            Console.Clear();
            Console.WriteLine("1-Birim fiyatlari göster.");
            Console.WriteLine("2-Birim fiyatlari güncelle.");
            Console.WriteLine("3-Akaryakıt satısı yap.");
            Console.WriteLine("4-tank durumunu sorgula.");
            Console.WriteLine("5-Toplam satışı sorgula.");
            Console.WriteLine("6-Toplam ciroyu sorgula.");
            Console.WriteLine("7-Çıkış.");


            Console.Write("Secim yapınız: ");
            secim1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            switch (secim1)
            {
                case 1:
                    Console.WriteLine("Dizel fiyat:{0} Benzin fiyat:{1} Lpg fiyat:{2}", dfiyat, bfiyat, lfiyat);
                    Console.WriteLine("1-Ana menüye dön.");
                    Console.WriteLine("2-Çıkış.");
                    secim3 = Convert.ToInt32(Console.ReadLine());
                    switch (secim3)
                    {
                        case 1:
                            goto anamenu;
                            break;
                        case 2:
                            goto son;
                            break;
                        default:
                            Console.Write("Hatalı giriş.");
                            goto sor;
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Dizel fiyat:{0} Benzin fiyat:{1} Lpg fiyat:{2}", dfiyat, bfiyat, lfiyat);
                fmenu:
                    Console.WriteLine("Dizel[1]  Benzin[2]  Lpg[3]");
                    Console.Write("Seçim yapınız: ");
                    secim2 = Convert.ToInt32(Console.ReadLine());
                    switch (secim2)
                    {
                        case 1:
                            Console.Write("Dizel icin yeni lt fiyatini giriniz: ");
                            dfiyat = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Benzin icin yeni lt fiyatini giriniz: ");
                            bfiyat = Convert.ToDouble(Console.ReadLine());
                            break;
                        case 3:
                            Console.Write("LPG icin yeni lt fiyatini giriniz: ");
                            lfiyat = Convert.ToDouble(Console.ReadLine());
                            break;
                        default:
                            Console.WriteLine("hatalı seçim");
                            goto fmenu;
                    }
                    Console.Clear();
                    Console.WriteLine("Dizel fiyat:{0} Benzin fiyat:{1} Lpg fiyat:{2}", dfiyat, bfiyat, lfiyat);
                    Console.WriteLine("1-Ana menüye dön.");
                    Console.WriteLine("2-Çıkış.");
                fiyatsec:
                    secim3 = Convert.ToInt32(Console.ReadLine());
                    switch (secim3)
                    {
                        case 1:
                            goto anamenu;
                            break;
                        case 2:
                            goto son;
                            break;
                        default:
                            Console.WriteLine("Hatali giris..");
                            goto fiyatsec;
                    }
                    break;
                case 3:
                    Console.Write("Dizel[1]  Benzin[2]  Lpg[3] satın alacağınız yakıtı seçiniz: ");

                satınal:
                    secim2 = Convert.ToInt32(Console.ReadLine());
                    switch (secim2)
                    {
                        case 1:
                            Console.Write("Dizel akaryakıtından kac Lt almak istiyorsunuz: ");
                            miktar = Convert.ToDouble(Console.ReadLine());
                            dtank = dtank - miktar;
                            dmiktar += miktar;
                            ciro += miktar * dfiyat;
                            Console.WriteLine("1-Ana menüye dön.");
                            Console.WriteLine("2-Çıkış.");
                            secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    goto anamenu;
                                    break;
                                case 2:
                                    goto son;
                                    break;
                                default:
                                    Console.Write("Hatalı giriş.");
                                    goto satınal;
                                    break;
                            }

                            break;
                        case 2:
                            Console.Write("Benzin akaryakıtından kac Lt almak istiyorsunuz: ");
                            miktar = Convert.ToDouble(Console.ReadLine());
                            btank = btank - miktar;
                            bmiktar += miktar;
                            ciro += miktar * bfiyat;
                            Console.WriteLine("1-Ana menüye dön.");
                            Console.WriteLine("2-Çıkış.");
                            secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    goto anamenu;
                                    break;
                                case 2:
                                    goto son;
                                    break;
                                default:
                                    Console.Write("Hatalı giriş.");
                                    goto satınal;
                                    break;
                            }
                            break;
                        case 3:
                            Console.Write("Lpg akaryakıtından kac Lt almak istiyorsunuz: ");
                            miktar = Convert.ToDouble(Console.ReadLine());
                            ltank = ltank - miktar;
                            lmiktar += miktar;
                            ciro += miktar * lfiyat;
                            Console.WriteLine("1-Ana menüye dön.");
                            Console.WriteLine("2-Çıkış.");
                            secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    goto anamenu;
                                    break;
                                case 2:
                                    goto son;
                                    break;
                                default:
                                    Console.Write("Hatalı giriş.");
                                    goto satınal;
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Hatalı giriş.Tekrar seçiniz.");
                            goto satınal;
                            break;
                    }
                    break;
                case 4:
                    Console.Write("Dizel[1]  Benzin[2]  Lpg[3] hangi tanki sorgulamak istiyorsunuz: ");
                tanksor:
                    secim2 = Convert.ToInt32(Console.ReadLine());
                    switch (secim2)
                    {
                        case 1:
                            Console.WriteLine("Dizel tankinda {0}Lt bulunuyor", dtank);
                            Console.WriteLine("1-Ana menüye dön.");
                            Console.WriteLine("2-Çıkış.");
                            secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    goto anamenu;
                                    break;
                                case 2:
                                    goto son;
                                    break;
                                default:
                                    Console.Write("Hatalı giriş.");
                                    goto tanksor;
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Benzin tankinda {0}Lt bulunuyor", btank);
                            Console.WriteLine("1-Ana menüye dön.");
                            Console.WriteLine("2-Çıkış.");
                            secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    goto anamenu;
                                    break;
                                case 2:
                                    goto son;
                                    break;
                                default:
                                    Console.Write("Hatalı giriş.");
                                    goto tanksor;
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Lpg tankinda {0}Lt bulunuyor", ltank);
                            Console.WriteLine("1-Ana menüye dön.");
                            Console.WriteLine("2-Çıkış.");
                            secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    goto anamenu;
                                    break;
                                case 2:
                                    goto son;
                                    break;
                                default:
                                    Console.Write("Hatalı giriş.");
                                    goto tanksor;
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Hatali giris..");
                            goto tanksor;
                            break;
                    }

                    break;
                case 5:
                    Console.Write("Dizel[1]  Benzin[2]  Lpg[3] hangi akaryakıt satışını sorgulamak istiyorsunuz: ");
                sor:
                    secim2 = Convert.ToInt32(Console.ReadLine());

                    switch (secim2)
                    {
                        case 1:
                            Console.WriteLine("Dizel yakıtından {0}LT satis yapılmıştır", dmiktar);
                            Console.WriteLine("1-Ana menüye dön.");
                            Console.WriteLine("2-Çıkış.");
                            secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    goto anamenu;
                                    break;
                                case 2:
                                    goto son;
                                    break;
                                default:
                                    Console.Write("Hatalı giriş.");
                                    goto sor;
                                    break;
                            }
                        case 2:
                            Console.WriteLine("Benzin yakıtından {0}LT satis yapılmıştır", bmiktar);
                            Console.WriteLine("1-Ana menüye dön.");
                            Console.WriteLine("2-Çıkış.");
                            secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    goto anamenu;
                                    break;
                                case 2:
                                    goto son;
                                    break;
                                default:
                                    Console.Write("Hatalı giriş.");
                                    goto sor;
                                    break;
                            }

                        case 3:
                            Console.WriteLine("Dizel yakıtından {0}LT satis yapılmıştır", lmiktar);
                            Console.WriteLine("1-Ana menüye dön.");
                            Console.WriteLine("2-Çıkış.");
                            secim3 = Convert.ToInt32(Console.ReadLine());
                            switch (secim3)
                            {
                                case 1:
                                    goto anamenu;
                                    break;
                                case 2:
                                    goto son;
                                    break;
                                default:
                                    Console.Write("Hatalı giriş.");
                                    goto sor;
                                    break;
                            }

                        default:
                            Console.WriteLine("hatali giris..");
                            goto sor;
                            break;
                    }

                    break;
                case 6:
                    Console.WriteLine("ciro: " + ciro + "Tl");
                    Console.WriteLine("1-Ana menüye dön.");
                    Console.WriteLine("2-Çıkış.");
                    secim3 = Convert.ToInt32(Console.ReadLine());
                    switch (secim3)
                    {
                        case 1:
                            goto anamenu;
                            break;
                        case 2:
                            goto son;
                            break;
                        default:
                            Console.Write("Hatalı giriş.");
                            goto sor;
                            break;
                    }
                    break;

                case 7:
                    goto son;
                    break;


                default:
                    goto anamenu;
                    break;

            }

        son:
            Console.WriteLine("Program Sonlandı");
            Console.ReadKey();
        }
    }
}

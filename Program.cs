using System;

class Program
{
    static void Main()
    {
        string[] urunler = new string[50];
        int[] fiyatlar = new int[50];
        int urunSayisi = 3;
        int gunSonuSatis = 0;

        urunler[0] = "Fanta";
        fiyatlar[0] = 40;
        urunler[1] = "Kola";
        fiyatlar[1] = 40;
        urunler[2] = "Çikolata";
        fiyatlar[2] = 30;

        while (true)
        {
            Console.WriteLine("1 - Müşteri Ekranı");
            Console.WriteLine("2 - Admin Paneli");
            Console.WriteLine("0 - Çıkış");
            int modSecimi = Convert.ToInt32(Console.ReadLine());

            if (modSecimi == 1)
            {
                for (int i = 0; i < urunSayisi; i++)
                {
                    Console.WriteLine((i + 1) + " - " + urunler[i] + " " + fiyatlar[i] + " TL");
                }

                Console.WriteLine("Ürün numarası seçin:");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim > 0 && secim <= urunSayisi)
                {
                    int index = secim - 1;
                    int urunFiyati = fiyatlar[index];

                    Console.WriteLine("Para atın:");
                    int yatirilanPara = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {
                        if (yatirilanPara == urunFiyati)
                        {
                            Console.WriteLine("Afiyet olsun");
                            gunSonuSatis = gunSonuSatis + urunFiyati;
                            break;
                        }
                        else if (yatirilanPara > urunFiyati)
                        {
                            int paraUstu = yatirilanPara - urunFiyati;
                            Console.WriteLine("Afiyet olsun, para üstü: " + paraUstu + " alınız");
                            gunSonuSatis = gunSonuSatis + urunFiyati;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Yetersiz bakiye");
                            Console.WriteLine("1 - Para Ekle");
                            Console.WriteLine("2 - Para İade");
                            int odeme = Convert.ToInt32(Console.ReadLine());

                            if (odeme == 1)
                            {
                                Console.WriteLine("Eklenecek tutar:");
                                int ekPara = Convert.ToInt32(Console.ReadLine());
                                yatirilanPara = yatirilanPara + ekPara;
                            }
                            else
                            {
                                Console.WriteLine("Para iade edildi");
                                break;
                            }
                        }
                    }
                }
            }
            else if (modSecimi == 2)
            {
                while (true)
                {
                    Console.WriteLine("1 - Ekle");
                    Console.WriteLine("2 - Güncelle");
                    Console.WriteLine("3 - Sil");
                    Console.WriteLine("4 - Listele");
                    Console.WriteLine("0 - Geri");
                    int adminSecim = Convert.ToInt32(Console.ReadLine());

                    if (adminSecim == 1)
                    {
                        if (urunSayisi < 50)
                        {
                            Console.WriteLine("Ürün adı:");
                            urunler[urunSayisi] = Console.ReadLine();
                            Console.WriteLine("Ürün fiyatı:");
                            fiyatlar[urunSayisi] = Convert.ToInt32(Console.ReadLine());
                            urunSayisi = urunSayisi + 1;
                        }
                        else
                        {
                            Console.WriteLine("Makine kapasitesi dolu");
                        }
                    }
                    else if (adminSecim == 2)
                    {
                        for (int i = 0; i < urunSayisi; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + urunler[i] + " " + fiyatlar[i] + " TL");
                        }

                        Console.WriteLine("Güncellenecek ürün numarası:");
                        int guncelIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (guncelIndex >= 0 && guncelIndex < urunSayisi)
                        {
                            Console.WriteLine("Yeni ürün adı:");
                            urunler[guncelIndex] = Console.ReadLine();
                            Console.WriteLine("Yeni fiyat:");
                            fiyatlar[guncelIndex] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    else if (adminSecim == 3)
                    {
                        for (int i = 0; i < urunSayisi; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + urunler[i] + " " + fiyatlar[i] + " TL");
                        }

                        Console.WriteLine("Silinecek ürün numarası:");
                        int silIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                        if (silIndex >= 0 && silIndex < urunSayisi)
                        {
                            for (int i = silIndex; i < urunSayisi - 1; i++)
                            {
                                urunler[i] = urunler[i + 1];
                                fiyatlar[i] = fiyatlar[i + 1];
                            }
                            urunSayisi = urunSayisi - 1;
                        }
                    }
                    else if (adminSecim == 4)
                    {
                        for (int i = 0; i < urunSayisi; i++)
                        {
                            Console.WriteLine((i + 1) + " - " + urunler[i] + " " + fiyatlar[i] + " TL");
                        }
                    }
                    else if (adminSecim == 0)
                    {
                        break;
                    }
                }
            }
            else if (modSecimi == 0)
            {
                break;
            }
        }
    }
}
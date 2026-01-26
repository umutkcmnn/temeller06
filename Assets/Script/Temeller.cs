using NUnit.Framework;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class Temeller : MonoBehaviour
{


    // Program baþladýðýnda 1 kez çalýþýr.

   /* [SerializeField] public int say1;
    [SerializeField] public int say2;
    [SerializeField] public int Not;
    [SerializeField] public int Sýnav1;
    [SerializeField] public int Sýnav2;
    [SerializeField] public int Performans;
    [SerializeField] public int Acý1;
    [SerializeField] public int Acý2;
    [SerializeField] public int Acý3;
    [SerializeField] public int Bagajkýlo;
    [SerializeField] public string secým;
   */
    [SerializeField] public int girilensayý;



    void Start()
    {
        //print("Merhaba Unity'e Hoþgeldiniz.");
        //Debug.Log("Ekrana mesaj verdiriyoruz.Daha geliþmiþ bir kod.");

        //Deðiþken tanýmlama
        //String tanýmlama

        /* string ad = "Umut";
         string soyad = "KOCAMAN";
         Debug.Log("Sayýn : " + ad + " " + soyad);
        */

        //Sayýsal deðiþken tanýmlama

        //int damage = 10;
        //Debug.Log("Vereceði hasar : " + damage);

        //Ondalýklý sayý tanýmlama

        /* float ondalikliBir = 1 / 3f;
        Debug.Log("floatýn hassasiyeti : " + ondalikliBir);
        double ondalikliÝki = 1 / 3d;
        Debug.Log("double'ýn hassasiyeti : " + ondalikliÝki);
        float kilo = 65.8f;
        Debug.Log("kilonuz : " + kilo);
        double gold = 7.587878d;
        Debug.Log("gold ons : " + gold);
        */

        // karakter tanýmlama

        /* char cinsiyet = 'E';
        Debug.Log("Cinsiyetiniz : " + cinsiyet);
        // Boolen tanýmlama    0,1   true , false
        bool isDeath;
        isDeath = true;
        Debug.Log("Karakter öldü mü ? : " + isDeath);
        */

        //Aritmetik Operatörler + , - , / , * , % (mod alma)

        // hard code

        /* int say1 = 55;
        int say2 = 20;
        int toplam = say1 + say2;
        Debug.Log("Sayýlarýn toplamý : " + toplam);
        int fark = say1 - say2;
        Debug.Log("Sayýlarýn farký : " + fark);
        int carpim = say1 * say2;
        Debug.Log("Sayýlarýn çarpýmý : " + carpim);
        int bolme = say1 % say2;
        Debug.Log("Bölme iþlem sonucu : " + bolme);
        int kalan = say1 % say2;
        Debug.Log(say1 + "'in " + say2 + "'ye bölümünden kalan : " + kalan);
        */

        //Biraz dinamikleþtirelim.
        // int toplam2 = say1 + say2;
        // Debug.Log("Girdiðiniz sayýlarýn toplamý :" + toplam2);

        // Tekli Operatörler x++ , x-- , ++x , --x

        // x++ : x = x+1
        // x-- : x = x-1
        // ++x : Deðere +1 ekler

        /*
        int puan = 0;
        puan++;//1
        puan++;//2
        puan++;//3
        puan--;//2
        puan--;//1
        ++puan;//2
        --puan;//1
        Debug.Log("Puanýnýz : " + puan);
        */

        // Atama Operatörü : = , += , -= , /= , *=

        /*
        int score;// score adýnda bir deðiþken tanýmladýk.
        score = 10;// score deðiþkenine 10 sayýsýný atadýk.
        score += 10;// score = score + 10
        score -= 5;// score = score - 5
        score *= 2;// score = score * 2
        score /= 5;// score = score / 5
        Debug.Log("Skorumuz : " + score);
        */

        // Ýliþkisel Operatörler : < , > , <= , >= , != , ==
        // != : Eþit Deðilse
        // == : Eþitse

        /*
        int sayim1 = 28;
        int sayim2 = 57;
        Debug.Log(sayim1 < sayim2);
        Debug.Log(sayim1 > sayim2);
        Debug.Log(sayim1 <= sayim2);
        Debug.Log(sayim1 >= sayim2);
        Debug.Log(sayim1 != sayim2);
        Debug.Log(sayim1 == sayim2);
        */

        // Mantýksal Operatörler && (ve sembolü) (and) , || (veya) , ! (deðil)
        /*
        string kullaniciAdi = "Umutkcmn";
        string sifre = "265964";
        Debug.Log(kullaniciAdi == "Umutkcmn" && sifre == "265964");
        */
        /*
        string kullaniciAdi = "Umutkmn";
        string sifre = "265964";
        Debug.Log(kullaniciAdi == "Umutkcmnn" || sifre == "26596435606");
        */

        /*
        int a = 5;
        int b = 10;
        Debug.Log(!(a == b));
        */

        // Tür Dönüþümleri (type casting)
        /*
        float ondaliklisayi = 10 / 3f;
        Debug.Log(ondaliklisayi);
        Debug.Log((int)ondaliklisayi);
        */

        // Karar Yapýlarý
        /*
        int yas = 5;
        if (yas>=18)
        {
            Debug.Log("Yetiþkindir.");
        }
        else
        {
            Debug.Log("Yetiþkin Deðildir.");
        }
        */

        // Ders not ortalamasý
        /*
        if (Not <= 44) 
        {
            Debug.Log("1");
        }
        else if (Not <=54)
        {
            Debug.Log("2");
        }
        else if (Not <=69)
        {
            Debug.Log("3");
        }
        else if (Not <=84)
        {
            Debug.Log("4");
        }
        else if (Not <=100)
        {
            Debug.Log("5");
        }
        */

        //Baþarýlý - Baþarýsýz Çýktýlarý.
        /*
        int toplam = Sýnav1 + Sýnav2 + Performans;
        int ortalama = toplam / 3;
        if (ortalama >= 50)
        {
            Debug.Log("Baþarýlý");
        }
        else if (ortalama <= 50)
        {
            Debug.Log("Baþarýsýz");
        }
        */

        // Üçgen iç Açýlarý
        /*
        int toplam = Acý1 + Acý2 + Acý3;
        if (toplam == 180)
        {
            Debug.Log("Bu bir üçgendir");
        }
        else if (toplam != 180)
        {
            Debug.Log("Bu bir üçgen deðildir.");
        }
        */

        // Bagaj Kilo
        /*
        int aradakitutar = Bagajkýlo - 20;
        if (Bagajkýlo <=20)
        {
            Debug.Log("Herhangi bir ücret ödemeniz gerekmemektedir.");
        }
        else 
        {
            aradakitutar *= 10;
            Debug.Log("Ödemeniz gereken tutar : " + aradakitutar + "TL");
        }
        */

        // switch-case
        /*
        int sonuc = 0;
        switch (secým)
        {
            case "+":
                sonuc = say1 + say2;
                Debug.Log("sonuc : " + sonuc);
                break;
            case "-":
                sonuc = say1 - say2;
                Debug.Log("sonuc : " + sonuc);
                break;
            case "/":
                sonuc = say1 / say2;
                Debug.Log("sonuc : " + sonuc);
                break;
            case "*":
                sonuc = say1 * say2;
                Debug.Log("sonuc : " + sonuc);
                break;

        }
        */

        // Haftanýn günleri
        /*
        switch (secým)
        {
            case "1":
                Debug.Log("Bugün günlerden PAZARTESÝ");
                break;
            case "2":
                Debug.Log("Bugün günlerden SALI");
                break;
            case "3":
                Debug.Log("Bugün günlerden ÇARÞAMBA");
                break;
            case "4":
                Debug.Log("Bugün günlerden PERÞEMBE");
                break;
            case "5":
                Debug.Log("Bugün günlerden CUMA");
                break;
            case "6":
                Debug.Log("Bugün günlerden CUMARTESÝ");
                break;
            case "7":
                Debug.Log("Bugün günlerden PAZAR");
                break;
            default:
                Debug.Log("Geçersiz Gün");
                break;
        }
        */

        // Döngü Hakkýnda !!
        /*
        for (int i = 1 ; i < 10; i++)
        {
            Debug.Log(i + "Merhaba");

        }
        */

        // Deneme Döngü
        /*
        int toplam = 0;

        for (int i = say1 ; i <= say2; i++)
        {
            toplam += i;
            Debug.Log("Þu andaki sayý : " + i);

        }
        Debug.Log("Toplam sonuç : " + toplam);
        */

        // BOM OYUNU
        /*
        for (int i = say1 ; i < say2 ; i++)
        {
            if (i % 5 == 0)
            {
                Debug.Log("Bom");
            }
            else
            {
                Debug.Log(i);
            }
        }
        */

        // While Döngüsü
        /*
        int i = 1;
        while (i <= 10)
        {
            Debug.Log(i);
            i++; i = i + 1;
        }
        */

        // Faktoriyel Örnek
        /*
        int result = 1;
        int i = 1;
        while (i <= girilensayý)
        {
            result *= i;
            i++;
   
        }
           Debug.Log("Sayýnýn Faktoriyeli : " + result);
        */

        // Dizi (arrays)
        /*
        string[] isimler = new string[11];
        isimler[0] = "Umut Kocaman";
        isimler[1] = "Umut Kocaman";
        isimler[2] = "Umut Kocaman";
        isimler[3] = "Umut Kocaman";
        isimler[4] = "Umut Kocaman";
        isimler[5] = "Umut Kocaman";
        isimler[6] = "Umut Kocaman";
        isimler[7] = "Umut Kocaman";
        isimler[8] = "Umut Kocaman";
        isimler[9] = "Umut Kocaman";
        isimler[10] = "Umut Kocaman";

        int[] yas = new int[11];
        yas[0] = 22; yas[1] = 24; yas[2] = 25; yas[3] = 18;
        yas[4] = 16; yas[5] = 28; yas[6] = 33; yas[7] = 35;
        yas[8] = 24; yas[9] = 27; yas[10] = 30;
        for (int i = 0; i < isimler.Length; i++)

        {
            Debug.Log(isimler[i]);
            Debug.Log(yas[i]);
        }
        */

        // Listeler
        /*
        List<string> isimler = new List<string>();

        isimler.Add("Umut KOCAMAN");
        isimler.Add("Umut KOCAMAN1");
        isimler.Add("Umut KOCAMAN2");
        isimler.Add("Umut KOCAMAN3");
        isimler.Add("Umut KOCAMAN4");
        isimler.Add("Umut KOCAMAN5");
        isimler.Add("Umut KOCAMAN6");

        foreach (string isim in isimler)
        {
            Debug.Log(isim);
        }

        // Listeden Eleman Çýkarmak Ýçin
        // Remove
        
        isimler.Remove("Umut KOCAMAN5");
        foreach (string isim in isimler)
        {
            Debug.Log(isim);
        }

        // ÝNSERT (Araya Eklemek)

        isimler.Insert(4, "Mahmut");
        foreach (string isim in isimler)
        {
            Debug.Log(isim);
        }

        // Contains (Ýçeriyor mu ?)

        if (isimler.Contains("Mahmut"))
        {
            Debug.Log("Mahmut Bulundu !!");
        }
        else
        {
            Debug.Log("Bulunamadý !!");
        }
        */










    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Ekrana mesaj verdiriyoruz.Daha geliþmiþ bir kod.");
    }
}

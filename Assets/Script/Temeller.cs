using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class Temeller : MonoBehaviour
{


    // Program baþladýðýnda 1 kez çalýþýr.

    [SerializeField] public int say1;
    [SerializeField] public int say2;


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
        int toplam2 = say1 + say2;
        Debug.Log("Girdiðiniz sayýlarýn toplamý :" + toplam2);


    }

    // Update is called once per frame
    void Update()
    {
       // Debug.Log("Ekrana mesaj verdiriyoruz.Daha geliþmiþ bir kod.");
    }
}

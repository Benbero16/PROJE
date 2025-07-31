using Unity.VisualScripting;
using UnityEngine;

public class DENEME : MonoBehaviour
{
   
    [SerializeField] public float urunFiyat1;
    [SerializeField] public float urunFiyat2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        /*int damage = 10;
        Debug.Log("verdiðiniz zarar : " +  damage); */


    }

    // Update is called once per frame
    private void Update()
    {
        /*  if (sayi == 0)
          {
              Debug.Log("Bu sayý 0 a eþit");
          }
          else if (sayi > 0)
          {

              Debug.Log("Bu sayý pozitiftir");

          }
          else
          {
              Debug.Log("Bu sayý negatiftir");
          }
        */



        /* int sinir = 20;
        int ekUcretKg = 10;

        if (bagajAgirligi <= sinir)
        {
            Debug.Log("Herhangi bir ücret ödemeniz gerekmiyor.");
        }
        else
        {
            int fazlaKg = bagajAgirligi - sinir;
            int toplamUcret = fazlaKg * ekUcretKg;
            Debug.Log("Fazla bagaj için " + toplamUcret + " TL ödemelisiniz.");
        }  */
        float toplamFiyat = urunFiyat1 + urunFiyat2;

        if (toplamFiyat <= 200)
        {
            Debug.Log("Ödenecek miktar = " + toplamFiyat + " TL");
        }
        else
        {
            float indirimliFiyat = toplamFiyat * 0.75f; // %25 indirim
            Debug.Log("Ödenecek miktar, indirimden sonra " + indirimliFiyat + " TL'dir.");
        }


    }

}
//[SerializeField] public int b = 10;
// Mantýksal Operatörler && (ve) , || (veya) ! (deðil)
/*
c) Bir hava yolu firmasý en fazla 20 kilogram bagaj hakký vermektedir. 20 kilogramdan sonraki her kilogram
için 10 TL ek ücret almaktadýr. Buna göre bagajý 20 kg ya da daha az olan yolculara “Herhangi bir ücret
ödemeniz gerekmiyor.”; 20 kg’den fazla olanlar için de ne kadar ek ücret ödeneceðini hesaplayarak “Fazla
bagaj için ….. TL ödemelisiniz.” çýktýlarýný veren kodu yazýnýz.
Not: Bu soruda kilogram hesabýnda sadece tam sayýlarý dikkate alýnýz. Örneðin 28,70 kilogram olan bagaj
için sadece 8 kg için ek ücret ödenmesi yeterlidir.
ç) Kullanýcýnýn girdiði iki ürünün toplam fiyatý 200 TL ve altýysa “Ödenecek miktar=…. TL”; 200 TL’yi geçerse
%25 indirim yaparak “Ödenecek miktar, indirimden sonra ….. TL’dir.” çýktýlarýný veren kodu yazýnýz.  */


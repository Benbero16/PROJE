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
        Debug.Log("verdi�iniz zarar : " +  damage); */


    }

    // Update is called once per frame
    private void Update()
    {
        /*  if (sayi == 0)
          {
              Debug.Log("Bu say� 0 a e�it");
          }
          else if (sayi > 0)
          {

              Debug.Log("Bu say� pozitiftir");

          }
          else
          {
              Debug.Log("Bu say� negatiftir");
          }
        */



        /* int sinir = 20;
        int ekUcretKg = 10;

        if (bagajAgirligi <= sinir)
        {
            Debug.Log("Herhangi bir �cret �demeniz gerekmiyor.");
        }
        else
        {
            int fazlaKg = bagajAgirligi - sinir;
            int toplamUcret = fazlaKg * ekUcretKg;
            Debug.Log("Fazla bagaj i�in " + toplamUcret + " TL �demelisiniz.");
        }  */
        float toplamFiyat = urunFiyat1 + urunFiyat2;

        if (toplamFiyat <= 200)
        {
            Debug.Log("�denecek miktar = " + toplamFiyat + " TL");
        }
        else
        {
            float indirimliFiyat = toplamFiyat * 0.75f; // %25 indirim
            Debug.Log("�denecek miktar, indirimden sonra " + indirimliFiyat + " TL'dir.");
        }


    }

}
//[SerializeField] public int b = 10;
// Mant�ksal Operat�rler && (ve) , || (veya) ! (de�il)
/*
c) Bir hava yolu firmas� en fazla 20 kilogram bagaj hakk� vermektedir. 20 kilogramdan sonraki her kilogram
i�in 10 TL ek �cret almaktad�r. Buna g�re bagaj� 20 kg ya da daha az olan yolculara �Herhangi bir �cret
�demeniz gerekmiyor.�; 20 kg�den fazla olanlar i�in de ne kadar ek �cret �denece�ini hesaplayarak �Fazla
bagaj i�in �.. TL �demelisiniz.� ��kt�lar�n� veren kodu yaz�n�z.
Not: Bu soruda kilogram hesab�nda sadece tam say�lar� dikkate al�n�z. �rne�in 28,70 kilogram olan bagaj
i�in sadece 8 kg i�in ek �cret �denmesi yeterlidir.
�) Kullan�c�n�n girdi�i iki �r�n�n toplam fiyat� 200 TL ve alt�ysa ��denecek miktar=�. TL�; 200 TL�yi ge�erse
%25 indirim yaparak ��denecek miktar, indirimden sonra �.. TL�dir.� ��kt�lar�n� veren kodu yaz�n�z.  */


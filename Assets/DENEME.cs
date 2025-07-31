using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;
public class DENEME : MonoBehaviour
{

int topla(int sayi_1 , int sayi_2)
    {
        return sayi_1 + sayi_2;


    }
    int cikar(int sayi_1, int sayi_2)
    {
        return sayi_1 - sayi_2;
    }

    int carpma(int sayi_1, int sayi_2)
    {
        return sayi_1 * sayi_2;
    }

    float bol(int sayi_1, int sayi_2)
    {
        if (sayi_2 != 0)
            return (float) sayi_1 / sayi_2;
        else
            return float.NaN; // veya hata mesajý/log ekleyebilirsin
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        int sonuc_1 = topla(8, 4);
        Debug.Log(sonuc_1);
        int sonuc_2 = carpma(8, 4);
        Debug.Log(sonuc_2);
        int sonuc_3 = cikar(8, 4);
        Debug.Log(sonuc_3);
        float sonuc_4 = bol(8 , 4);
Debug.Log(sonuc_4);


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
        
         int sinir = 20;
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
              }  
      switch (secim) {
                  case "+":
                      Debug.Log("Toplam: " + (sayi_1 + sayi_2));
                      break;
                  case "-":
                      Debug.Log("Fark: " + (sayi_1 - sayi_2));
                      break;
                  case "*":
                      Debug.Log("Çarpým: " + (sayi_1 * sayi_2));
                      break;
                  case "/":
                      if (sayi_2 != 0)
                          Debug.Log("Bölüm: " + (sayi_1 / sayi_2));
                      else
                          Debug.Log("Bölme iþlemi için ikinci sayý sýfýr olamaz!");
                      break;
                  default:
                      Debug.Log("Geçersiz seçim! ");
                      break;






              }

              */

        
     
    }
    }
//[SerializeField] public int b = 10;
// Mantýksal Operatörler && (ve) , || (veya) ! (deðil)



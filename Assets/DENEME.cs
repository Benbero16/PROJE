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
            return float.NaN; // veya hata mesaj�/log ekleyebilirsin
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
        
         int sinir = 20;
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
              }  
      switch (secim) {
                  case "+":
                      Debug.Log("Toplam: " + (sayi_1 + sayi_2));
                      break;
                  case "-":
                      Debug.Log("Fark: " + (sayi_1 - sayi_2));
                      break;
                  case "*":
                      Debug.Log("�arp�m: " + (sayi_1 * sayi_2));
                      break;
                  case "/":
                      if (sayi_2 != 0)
                          Debug.Log("B�l�m: " + (sayi_1 / sayi_2));
                      else
                          Debug.Log("B�lme i�lemi i�in ikinci say� s�f�r olamaz!");
                      break;
                  default:
                      Debug.Log("Ge�ersiz se�im! ");
                      break;






              }

              */

        
     
    }
    }
//[SerializeField] public int b = 10;
// Mant�ksal Operat�rler && (ve) , || (veya) ! (de�il)



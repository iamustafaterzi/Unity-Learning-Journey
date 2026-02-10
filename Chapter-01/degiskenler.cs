using System;
using UnityEngine;

public class degiskenler1 : MonoBehaviour
{
    /*
     string  // metinsel verileri içerir.
     int     // sayısal değerleri 
     float   // kayan sayıları 3.1012
     double  // daha büyük kayan sayılar 3.1234234
     Boolean // herhangi bir şeyin aktif veya pasif olmasını kontrol eder. true / false 

            */

    /*
        // class içerisinde değer tanımlama
        string metnim = "Merhaba Mustafa";
        int yas = 80;
        float kusurat = 3.10f;
        double kusurat2 = 3.21212;
        bool acikmi = false;
        // class içerisinde değer tanımlama
        */
    // sadece değişkenlerin isimlerini ve türlerini belirliyorum
    string metnim;
    int yas;
    float kusurat;
    double kusurat2;
    bool acikmi;
    // sadece değişkenlerin isimlerini ve türlerini belirliyorum

    void Start()
    {
        // işlemler yaptım sorgular yaptım ve değişkenin değeri şu an oluştu

        metnim = "icerde";

        Debug.Log(metnim);
        Debug.Log(yas);
        Debug.Log(kusurat);
        Debug.Log(kusurat2);
        Debug.Log(acikmi);
    }

}


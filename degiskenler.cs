using System;
using UnityEngine;

public class degiskenler1 : MonoBehaviour
{
    /*
     string  // metinsel verileri içerir.
     int     // sayýsal deðerleri 
     float   // kayan sayýlarý 3.1012
     double  // daha büyük kayan sayýlar 3.1234234
     Boolean // herhangi bir þeyin aktif veya pasif olmasýný kontrol eder. true / false 

            */

    /*
        // class içerisinde deðer tanýmlama
        string metnim = "Merhaba Mustafa";
        int yas = 80;
        float kusurat = 3.10f;
        double kusurat2 = 3.21212;
        bool acikmi = false;
        // class içerisinde deðer tanýmlama
        */
    // sadece deðiþkenlerin isimlerini ve türlerini belirliyorum
    string metnim;
    int yas;
    float kusurat;
    double kusurat2;
    bool acikmi;
    // sadece deðiþkenlerin isimlerini ve türlerini belirliyorum

    void Start()
    {
        // iþlemler yaptým sorgular yaptým ve deðiþkenin deðeri þu an oluþtu

        metnim = "icerde";

        Debug.Log(metnim);
        Debug.Log(yas);
        Debug.Log(kusurat);
        Debug.Log(kusurat2);
        Debug.Log(acikmi);
    }

}

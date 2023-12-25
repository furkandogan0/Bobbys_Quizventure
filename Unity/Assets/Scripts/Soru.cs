using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Soru 
{
    public string Sorutext;
    public string Asikki;
    public string Bsikki;
    public string Csikki;
    public string Dsikki;
    public string Cevap;
    public Sprite Resim;

     public void Sorular(string sorutext,string asikki, string bsikki, string csikki, string dsikki, string cevap,Sprite resim)
    {
        Sorutext = sorutext;
        Asikki = asikki;
        Bsikki = bsikki;
        Csikki = csikki;
        Dsikki = dsikki;
        Cevap = cevap;
        Resim = resim;








    }
}

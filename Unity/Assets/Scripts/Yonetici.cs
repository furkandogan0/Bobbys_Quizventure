using System.Collections;
using System.Collections.Generic;
using TMPro; // TextMeshPro ekledik
using UnityEngine;
using UnityEngine.UI;


public class Yonetici : MonoBehaviour
{
    public GameObject sandikObjesi;
    public Veriler Verim;
    public Soru SuankiSoru;
    public TMP_Text Sorutexts; // TextMeshPro için TMP_Text kullandýk
    public TMP_Text Asikkis;
    public TMP_Text Bsikkis;
    public TMP_Text Csikkis;
    public TMP_Text Dsikkis;
    public Image Resims;
   

    public int Randomid;
    public void Awake()
    {
        Soruver();
    }

    public void Update()
    {
        if (SuankiSoru.Resim == null)
        {

            Resims.enabled = false; 
        }
        else
        {
            Resims.enabled = true;  
        }
    }
    public void Soruver()
    {
        Randomid = Random.Range(0, Verim.Sorular.Count - 1);
        SuankiSoru = Verim.Sorular[Randomid];
        Sorutexts.text = SuankiSoru.Sorutext;
        Asikkis.text = SuankiSoru.Asikki;
        Bsikkis.text = SuankiSoru.Bsikki;
        Csikkis.text = SuankiSoru.Csikki;
        Dsikkis.text = SuankiSoru.Dsikki;
        Resims.GetComponent<Image>().sprite = SuankiSoru.Resim;
    }

    public void Cevapver(string sik)
    {
        if (sik == SuankiSoru.Cevap)
        {
            Debug.Log("Tebrikler");
            Soruver();
            GameManager.instance.ReturnToLastCheckpointTrue();

        }
        else
        {
            Debug.Log("Yanlýþ");
            Soruver();
            GameManager.instance.ReturnToLastCheckpoint();
        }
    }
}

//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;
//using TMPro;

//public class Yonetici : MonoBehaviour
//{
//    public Veriler Verim;
//    public TMP_Text Sorutexts;
//    public TMP_Text Asikkis;
//    public TMP_Text Bsikkis;
//    public TMP_Text Csikkis;
//    public TMP_Text Dsikkis;
//    public Image Resims;

//    private int kaldiginSahneIndeksi = 0;

//    void Start()
//    {
//        // Kaldýðýnýz sahne indeksini kontrol edin
//        if (PlayerPrefs.HasKey("KaldiginSahne"))
//        {
//            kaldiginSahneIndeksi = PlayerPrefs.GetInt("KaldiginSahne");
//        }

//        Soruver();
//    }

//    public void Soruver()
//    {
//        int Randomid = Random.Range(0, Verim.Sorular.Count - 1);
//        Soru SuankiSoru = Verim.Sorular[Randomid];

//        Sorutexts.text = SuankiSoru.Sorutext;
//        Asikkis.text = SuankiSoru.Asikki;
//        Bsikkis.text = SuankiSoru.Bsikki;
//        Csikkis.text = SuankiSoru.Csikki;
//        Dsikkis.text = SuankiSoru.Dsikki;
//        Resims.sprite = SuankiSoru.Resim;
//    }

//    public void Cevapver(string sik)
//    {
//        int Randomid = Random.Range(0, Verim.Sorular.Count - 1);
//        Soru SuankiSoru = Verim.Sorular[Randomid];

//        if (sik == SuankiSoru.Cevap)
//        {
//            Debug.Log("Tebrikler");
//            kaldiginSahneIndeksi++;
//            PlayerPrefs.SetInt("KaldiginSahne", kaldiginSahneIndeksi);
//            PlayerPrefs.Save();
//            Soruver();
//        }
//        else
//        {
//            Debug.Log("Yanlýþ");
//            Soruver();
//        }
//    }
//}


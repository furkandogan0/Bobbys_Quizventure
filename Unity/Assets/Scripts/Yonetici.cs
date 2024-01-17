//using System.Collections;
//using System.Collections.Generic;
//using TMPro; // TextMeshPro ekledik
//using UnityEngine;
//using UnityEngine.UI;


//public class Yonetici : MonoBehaviour
//{
//    public GameObject sandikObjesi;
//    public Veriler Verim;
//    public Soru SuankiSoru;
//    public TMP_Text Sorutexts; // TextMeshPro i�in TMP_Text kulland�k
//    public TMP_Text Asikkis;
//    public TMP_Text Bsikkis;
//    public TMP_Text Csikkis;
//    public TMP_Text Dsikkis;
//    public Image Resims;


//    public int Randomid;
//    public void Awake()
//    {
//        Soruver();
//    }

//    public void Update()
//    {
//        if (SuankiSoru.Resim == null)
//        {

//            Resims.enabled = false; 
//        }
//        else
//        {
//            Resims.enabled = true;  
//        }
//    }
//    public void Soruver()
//    {
//        Randomid = Random.Range(0, Verim.Sorular.Count - 1);
//        SuankiSoru = Verim.Sorular[Randomid];
//        Sorutexts.text = SuankiSoru.Sorutext;
//        Asikkis.text = SuankiSoru.Asikki;
//        Bsikkis.text = SuankiSoru.Bsikki;
//        Csikkis.text = SuankiSoru.Csikki;
//        Dsikkis.text = SuankiSoru.Dsikki;
//        Resims.GetComponent<Image>().sprite = SuankiSoru.Resim;
//    }

//    public void Cevapver(string sik)
//    {
//        if (sik == SuankiSoru.Cevap)
//        {
//            Debug.Log("Tebrikler");
//            Soruver();
//            GameManager.instance.ReturnToLastCheckpointTrue();

//        }
//        else
//        {
//            Debug.Log("Yanl��");
//            Soruver();
//            GameManager.instance.ReturnToLastCheckpoint();
//        }
//    }
//}

using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Yonetici : MonoBehaviour
{
    public List<GameObject> sandikObjeleri; // Birden fazla sand�k objesini buraya atay�n
    

    public Veriler Verim;
    public Soru SuankiSoru;
    public TMP_Text Sorutexts;
    public TMP_Text Asikkis;
    public TMP_Text Bsikkis;
    public TMP_Text Csikkis;
    public TMP_Text Dsikkis;
    public Image Resims;
   
    


    private void Awake()
    {
        Soruver();
    }

    private void Soruver()
    {
        int randomID = Random.Range(0, Verim.Sorular.Count);
        SuankiSoru = Verim.Sorular[randomID];
        Sorutexts.text = SuankiSoru.Sorutext;
        Asikkis.text = SuankiSoru.Asikki;
        Bsikkis.text = SuankiSoru.Bsikki;
        Csikkis.text = SuankiSoru.Csikki;
        Dsikkis.text = SuankiSoru.Dsikki;
        Resims.sprite = SuankiSoru.Resim;

        UpdateResimDurumu();
    }

    private void UpdateResimDurumu()
    {
        Resims.enabled = SuankiSoru.Resim != null;
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
            Debug.Log("Yanl��");
            Soruver();
            GameManager.instance.ReturnToLastCheckpoint();
        }
    }

   


}


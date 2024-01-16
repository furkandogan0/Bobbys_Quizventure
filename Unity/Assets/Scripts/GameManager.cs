//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class GameManager : MonoBehaviour
//{
//    public static GameManager instance; // Singleton instance

//    private Vector3 lastCheckpointPosition;
//    private bool isCheckpointSet = false;


//    private void Start()
//    {
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        if (player != null)
//        {
//            Debug.Log("Player bulundu.");
//            // Devam eden iþlemler...
//        }
//        else
//        {
//            Debug.LogError("Player objesi bulunamadý veya 'Player' tag'i atanmamýþ.");
//        }
//    }
//    void Awake()
//    {
//        if (instance == null)
//        {
//            instance = this;
//            DontDestroyOnLoad(gameObject);
//        }
//        else
//        {
//            Destroy(gameObject);
//        }
//    }

//    // Metod, checkpoint pozisyonunu günceller
//    public void SetCheckpoint(Vector3 checkpointPos)
//    {


//        Debug.Log("SetCheckpoint Çalýþtý");
//        lastCheckpointPosition = checkpointPos;
//        isCheckpointSet = true;
//    }

//    // Metod, oyuncuyu en son checkpoint'e geri döndürür
//    public void ReturnToLastCheckpoint()
//    {
//        if (isCheckpointSet)
//        {
//            // Burada karakter veya kamera pozisyonunu güncelle
//            // Örnek olarak:
//            // playerTransform.position = lastCheckpointPosition; 
//            // Sahneyi yeniden yükleme yerine pozisyonu güncellemeyi tercih edebilirsin

//            Debug.Log(lastCheckpointPosition);
//            Debug.Log("Ýf Çalýþtý");


//            SceneManager.LoadScene("SampleScene");
//            SceneManager.LoadScene("SampleScene", new LoadSceneParameters(LoadSceneMode.Single, lastCheckpointPosition));
//            GameObject Player = GameObject.FindGameObjectWithTag("Player");
//            if (Player != null)
//            {
//                Player.transform.position = lastCheckpointPosition;
//            }
//            else
//            {
//                Debug.LogError("Player objesi bulunamadý veya 'Player' tag'i atanmamýþ.");
//            }
//        }
//        else
//        {
//            Debug.Log("Checkpoint bulunamadý.");
//            // Eðer checkpoint yoksa, baþlangýç pozisyonuna git veya varsayýlan bir pozisyona yerleþtir
//        }
//    }
//}


//using UnityEngine.SceneManagement;
//using UnityEngine;

//public class GameManager : MonoBehaviour
//{
//    private Vector3 startingPosition;
//    private Vector3 lastCheckpointPosition;
//    private bool isCheckpointSet = false;

//    private void OnEnable()
//    {
//        SceneManager.sceneLoaded += OnSceneLoaded;
//    }

//    private void OnDisable()
//    {
//        SceneManager.sceneLoaded -= OnSceneLoaded;
//    }

//    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
//    {
//        GameObject player = GameObject.FindGameObjectWithTag("Player");
//        if (player != null)
//        {
//            if (isCheckpointSet)
//            {
//                player.transform.position = lastCheckpointPosition;
//            }
//            else
//            {
//                player.transform.position = startingPosition;
//            }
//        }
//    }

//    public void SetStartingPosition(Vector3 startPos)
//    {
//        startingPosition = startPos;
//    }

//    public void SetCheckpoint(Vector3 checkpointPos)
//    {
//        Debug.Log("SetCheckpoint Çalýþtý");
//        lastCheckpointPosition = checkpointPos;
//        isCheckpointSet = true;
//    }

//    public void ReturnToLastCheckpoint()
//    {
//        if (isCheckpointSet)
//        {
//            GameObject player = GameObject.FindGameObjectWithTag("Player");
//            if (player != null)
//            {
//                player.transform.position = lastCheckpointPosition;
//            }
//        }
//        else
//        {
//            Debug.Log("Checkpoint bulunamadý.");
//            // Eðer checkpoint yoksa, baþlangýç pozisyonuna git veya varsayýlan bir pozisyona yerleþtir
//        }
//    }
//}


//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class GameManager : MonoBehaviour
//{
//    public static GameManager instance; // Singleton instance

//    private Vector3 lastCheckpointPosition;
//    private Vector3 lastPlayerPosition; // Player pozisyonunu saklamak için
//    private bool isCheckpointSet = false;

//    void Awake()
//    {
//        if (instance == null)
//        {
//            instance = this;
//            DontDestroyOnLoad(gameObject);
//        }
//        else
//        {
//            Destroy(gameObject);
//        }
//    }

//    // Metod, checkpoint pozisyonunu günceller
//    public void SetCheckpoint(Vector3 checkpointPos)
//    {
//        Debug.Log("SetCheckpoint Çalýþtý");
//        lastCheckpointPosition = checkpointPos;
//        isCheckpointSet = true;
//    }

//    // Metod, oyuncuyu en son checkpoint'e geri döndürür
//    public void SavePlayerPosition(Vector3 position)
//    {
//        lastPlayerPosition = position; // Player pozisyonunu sakla
//    }

//    public void ReturnToLastCheckpoint()
//    {
//        if (isCheckpointSet)
//        {
//            SceneManager.LoadScene("SampleScene"); // SampleScene'i yeniden yükle

//            GameObject Player = GameObject.FindGameObjectWithTag("Player");
//            if (Player != null)
//            {
//                Player.transform.position = lastPlayerPosition; // Kaydedilen pozisyona git

//            }
//            else
//            {
//                Debug.LogError("Player objesi bulunamadý veya 'Player' tag'i atanmamýþ.");
//            }
//        }
//        else
//        {
//            Debug.Log("Checkpoint bulunamadý.");
//            // Eðer checkpoint yoksa, baþlangýç pozisyonuna git veya varsayýlan bir pozisyona yerleþtir
//        }
//    }
//}


//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class GameManager : MonoBehaviour
//{
//    public static GameManager instance; // Singleton instance

//    private Vector3 lastCheckpointPosition;
//    private Vector3 lastPlayerPosition;
//    private bool isCheckpointSet = false;

//    void Awake()
//    {
//        if (instance == null)
//        {
//            instance = this;
//            DontDestroyOnLoad(gameObject);
//        }
//        else
//        {
//            Destroy(gameObject);
//        }
//    }

//    // Metod, checkpoint pozisyonunu günceller
//    public void SetCheckpoint(Vector3 checkpointPos)
//    {
//        Debug.Log("SetCheckpoint Çalýþtý");
//        lastCheckpointPosition = checkpointPos;
//        lastPlayerPosition = GetPlayerPosition(); // Player pozisyonunu kaydet
//        isCheckpointSet = true;
//    }

//    // Metod, oyuncuyu en son checkpoint'e geri döndürür
//    public void ReturnToLastCheckpoint()
//    {
//        if (isCheckpointSet)
//        {
//            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Sahneyi yeniden yükle

//            GameObject Player = GameObject.FindGameObjectWithTag("Player");
//            if (Player != null)
//            {
//                Player.transform.position = lastCheckpointPosition; // Karakter pozisyonunu güncelle
//            }
//            else
//            {
//                Debug.LogError("Player objesi bulunamadý veya 'Player' tag'i atanmamýþ.");
//            }
//        }
//        else
//        {
//            Debug.Log("Checkpoint bulunamadý.");
//            // Eðer checkpoint yoksa, baþlangýç pozisyonuna git veya varsayýlan bir pozisyona yerleþtir
//        }
//    }

//    // Player'ýn mevcut pozisyonunu alma
//    private Vector3 GetPlayerPosition()
//    {
//        GameObject Player = GameObject.FindGameObjectWithTag("Player");
//        if (Player != null)
//        {
//            return Player.transform.position;
//        }
//        else
//        {
//            Debug.LogError("Player objesi bulunamadý veya 'Player' tag'i atanmamýþ.");
//            return Vector3.zero;
//        }
//    }
//}



using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance; // Singleton instance
    public GameObject sandik;
    public int kazanilanAnahtarSayisi = 0;
    

    private Vector3 lastCheckpointPosition;
    private Vector3 lastPlayerPosition; // Player pozisyonunu saklamak için
    private bool isCheckpointSet = false;
    private Vector3 targetPos;


    void Start()
    {
        kazanilanAnahtarSayisi = 0;
        
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
           
        }
        UpdateSandikReference();
    }

    void UpdateSandikReference()
    {
        sandik = GameObject.Find("Chests");
    }

    // Metod, checkpoint pozisyonunu günceller
    public void SetCheckpoint(Vector3 checkpointPos)
    {
        Debug.Log("SetCheckpoint Çalýþtý");
        lastCheckpointPosition = checkpointPos;
        isCheckpointSet = true;
    }

    // Metod, oyuncuyu en son checkpoint'e geri döndürür
    public void ReturnToLastCheckpoint()
    {
        if (isCheckpointSet)
        {
            float backwardOffsetX = 2.0f; // Sadece X ekseni boyunca geri gitmek istediðiniz mesafe (örneðin 1 birim)
            targetPos = lastCheckpointPosition - new Vector3(backwardOffsetX, 0f, 0f); // Sadece X ekseni boyunca geri gitmek için negatif X vektörü kullanýlýyor
            SceneManager.LoadScene("SampleScene");
            SceneManager.sceneLoaded += OnSceneLoaded;
            
        }
        else
        {
            Debug.Log("Checkpoint bulunamadý.");
            // Eðer checkpoint yoksa, baþlangýç pozisyonuna git veya varsayýlan bir pozisyona yerleþtir
        }
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = targetPos; // Hedeflenen konuma git
        }
        else
        {
            Debug.LogError("Player objesi bulunamadý veya 'Player' tag'i atanmamýþ.");
        }
        
        
        

        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    public void ReturnToLastCheckpointTrue()
    {
        if (isCheckpointSet)
        {
            float backwardOffsetX = 2.0f; // Sadece X ekseni boyunca geri gitmek istediðiniz mesafe (örneðin 1 birim)
            targetPos = lastCheckpointPosition - new Vector3(backwardOffsetX, 0f, 0f); // Sadece X ekseni boyunca geri gitmek için negatif X vektörü kullanýlýyor
            SceneManager.LoadScene("SampleScene");
            SceneManager.sceneLoaded += OnSceneLoadedTrue;
            kazanilanAnahtarSayisi++;
            Debug.Log("Toplam Anahtar Sayýsý: " + kazanilanAnahtarSayisi);
            

        }
        else
        {
            Debug.Log("Checkpoint bulunamadý.");
            // Eðer checkpoint yoksa, baþlangýç pozisyonuna git veya varsayýlan bir pozisyona yerleþtir
        }
    }

    private void OnSceneLoadedTrue(Scene scene, LoadSceneMode mode)
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            player.transform.position = targetPos; // Hedeflenen konuma git
        }
        else
        {
            Debug.LogError("Player objesi bulunamadý veya 'Player' tag'i atanmamýþ.");
        }

        GameObject sandik = GameObject.FindGameObjectWithTag("Chests");
        

        if (sandik != null)
        {
            Destroy(sandik); // Sandýk objesini yok et
        }
        else
        {
            Debug.Log("Sandýk objesi bulunamadý.");
        }
        SceneManager.sceneLoaded -= OnSceneLoaded;
        
        
    }





}




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
//            // Devam eden i�lemler...
//        }
//        else
//        {
//            Debug.LogError("Player objesi bulunamad� veya 'Player' tag'i atanmam��.");
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

//    // Metod, checkpoint pozisyonunu g�nceller
//    public void SetCheckpoint(Vector3 checkpointPos)
//    {


//        Debug.Log("SetCheckpoint �al��t�");
//        lastCheckpointPosition = checkpointPos;
//        isCheckpointSet = true;
//    }

//    // Metod, oyuncuyu en son checkpoint'e geri d�nd�r�r
//    public void ReturnToLastCheckpoint()
//    {
//        if (isCheckpointSet)
//        {
//            // Burada karakter veya kamera pozisyonunu g�ncelle
//            // �rnek olarak:
//            // playerTransform.position = lastCheckpointPosition; 
//            // Sahneyi yeniden y�kleme yerine pozisyonu g�ncellemeyi tercih edebilirsin

//            Debug.Log(lastCheckpointPosition);
//            Debug.Log("�f �al��t�");


//            SceneManager.LoadScene("SampleScene");
//            SceneManager.LoadScene("SampleScene", new LoadSceneParameters(LoadSceneMode.Single, lastCheckpointPosition));
//            GameObject Player = GameObject.FindGameObjectWithTag("Player");
//            if (Player != null)
//            {
//                Player.transform.position = lastCheckpointPosition;
//            }
//            else
//            {
//                Debug.LogError("Player objesi bulunamad� veya 'Player' tag'i atanmam��.");
//            }
//        }
//        else
//        {
//            Debug.Log("Checkpoint bulunamad�.");
//            // E�er checkpoint yoksa, ba�lang�� pozisyonuna git veya varsay�lan bir pozisyona yerle�tir
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
//        Debug.Log("SetCheckpoint �al��t�");
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
//            Debug.Log("Checkpoint bulunamad�.");
//            // E�er checkpoint yoksa, ba�lang�� pozisyonuna git veya varsay�lan bir pozisyona yerle�tir
//        }
//    }
//}


//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class GameManager : MonoBehaviour
//{
//    public static GameManager instance; // Singleton instance

//    private Vector3 lastCheckpointPosition;
//    private Vector3 lastPlayerPosition; // Player pozisyonunu saklamak i�in
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

//    // Metod, checkpoint pozisyonunu g�nceller
//    public void SetCheckpoint(Vector3 checkpointPos)
//    {
//        Debug.Log("SetCheckpoint �al��t�");
//        lastCheckpointPosition = checkpointPos;
//        isCheckpointSet = true;
//    }

//    // Metod, oyuncuyu en son checkpoint'e geri d�nd�r�r
//    public void SavePlayerPosition(Vector3 position)
//    {
//        lastPlayerPosition = position; // Player pozisyonunu sakla
//    }

//    public void ReturnToLastCheckpoint()
//    {
//        if (isCheckpointSet)
//        {
//            SceneManager.LoadScene("SampleScene"); // SampleScene'i yeniden y�kle

//            GameObject Player = GameObject.FindGameObjectWithTag("Player");
//            if (Player != null)
//            {
//                Player.transform.position = lastPlayerPosition; // Kaydedilen pozisyona git

//            }
//            else
//            {
//                Debug.LogError("Player objesi bulunamad� veya 'Player' tag'i atanmam��.");
//            }
//        }
//        else
//        {
//            Debug.Log("Checkpoint bulunamad�.");
//            // E�er checkpoint yoksa, ba�lang�� pozisyonuna git veya varsay�lan bir pozisyona yerle�tir
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

//    // Metod, checkpoint pozisyonunu g�nceller
//    public void SetCheckpoint(Vector3 checkpointPos)
//    {
//        Debug.Log("SetCheckpoint �al��t�");
//        lastCheckpointPosition = checkpointPos;
//        lastPlayerPosition = GetPlayerPosition(); // Player pozisyonunu kaydet
//        isCheckpointSet = true;
//    }

//    // Metod, oyuncuyu en son checkpoint'e geri d�nd�r�r
//    public void ReturnToLastCheckpoint()
//    {
//        if (isCheckpointSet)
//        {
//            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Sahneyi yeniden y�kle

//            GameObject Player = GameObject.FindGameObjectWithTag("Player");
//            if (Player != null)
//            {
//                Player.transform.position = lastCheckpointPosition; // Karakter pozisyonunu g�ncelle
//            }
//            else
//            {
//                Debug.LogError("Player objesi bulunamad� veya 'Player' tag'i atanmam��.");
//            }
//        }
//        else
//        {
//            Debug.Log("Checkpoint bulunamad�.");
//            // E�er checkpoint yoksa, ba�lang�� pozisyonuna git veya varsay�lan bir pozisyona yerle�tir
//        }
//    }

//    // Player'�n mevcut pozisyonunu alma
//    private Vector3 GetPlayerPosition()
//    {
//        GameObject Player = GameObject.FindGameObjectWithTag("Player");
//        if (Player != null)
//        {
//            return Player.transform.position;
//        }
//        else
//        {
//            Debug.LogError("Player objesi bulunamad� veya 'Player' tag'i atanmam��.");
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
    private Vector3 lastPlayerPosition; // Player pozisyonunu saklamak i�in
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

    // Metod, checkpoint pozisyonunu g�nceller
    public void SetCheckpoint(Vector3 checkpointPos)
    {
        Debug.Log("SetCheckpoint �al��t�");
        lastCheckpointPosition = checkpointPos;
        isCheckpointSet = true;
    }

    // Metod, oyuncuyu en son checkpoint'e geri d�nd�r�r
    public void ReturnToLastCheckpoint()
    {
        if (isCheckpointSet)
        {
            float backwardOffsetX = 2.0f; // Sadece X ekseni boyunca geri gitmek istedi�iniz mesafe (�rne�in 1 birim)
            targetPos = lastCheckpointPosition - new Vector3(backwardOffsetX, 0f, 0f); // Sadece X ekseni boyunca geri gitmek i�in negatif X vekt�r� kullan�l�yor
            SceneManager.LoadScene("SampleScene");
            SceneManager.sceneLoaded += OnSceneLoaded;
            
        }
        else
        {
            Debug.Log("Checkpoint bulunamad�.");
            // E�er checkpoint yoksa, ba�lang�� pozisyonuna git veya varsay�lan bir pozisyona yerle�tir
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
            Debug.LogError("Player objesi bulunamad� veya 'Player' tag'i atanmam��.");
        }
        
        
        

        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    public void ReturnToLastCheckpointTrue()
    {
        if (isCheckpointSet)
        {
            float backwardOffsetX = 2.0f; // Sadece X ekseni boyunca geri gitmek istedi�iniz mesafe (�rne�in 1 birim)
            targetPos = lastCheckpointPosition - new Vector3(backwardOffsetX, 0f, 0f); // Sadece X ekseni boyunca geri gitmek i�in negatif X vekt�r� kullan�l�yor
            SceneManager.LoadScene("SampleScene");
            SceneManager.sceneLoaded += OnSceneLoadedTrue;
            kazanilanAnahtarSayisi++;
            Debug.Log("Toplam Anahtar Say�s�: " + kazanilanAnahtarSayisi);
            

        }
        else
        {
            Debug.Log("Checkpoint bulunamad�.");
            // E�er checkpoint yoksa, ba�lang�� pozisyonuna git veya varsay�lan bir pozisyona yerle�tir
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
            Debug.LogError("Player objesi bulunamad� veya 'Player' tag'i atanmam��.");
        }

        GameObject sandik = GameObject.FindGameObjectWithTag("Chests");
        

        if (sandik != null)
        {
            Destroy(sandik); // Sand�k objesini yok et
        }
        else
        {
            Debug.Log("Sand�k objesi bulunamad�.");
        }
        SceneManager.sceneLoaded -= OnSceneLoaded;
        
        
    }





}




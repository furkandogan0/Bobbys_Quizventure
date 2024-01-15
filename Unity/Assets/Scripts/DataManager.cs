using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using TigerForge;


public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    private int enemyKilled;
    public int totalEnemyKilled;
    private int openedChest;
    public int totalOpenedChest;

    EasyFileSave myFile;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int OpenedChest
    {
        get
        {
            return openedChest;
        }
        set
        {
            openedChest = value;
            GameObject.Find("OpenedChestText").GetComponent<Text>().text = "OPENED CHEST:" + openedChest.ToString();
        }
    }

    public int EnemyKilled
    {
        get
        {
            return enemyKilled;
        }
        set
        {
            enemyKilled = value;
            GameObject.Find("EnemyKilledText").GetComponent<Text>().text = "ENEMY KILLED : " + enemyKilled.ToString();
        }
    }

    void StartProcess()
    {
        myFile = new EasyFileSave();
        LoadData();
    }

    public void SaveData()
    {
        totalOpenedChest += OpenedChest;
        totalEnemyKilled += EnemyKilled;
        
        myFile.Add("totalOpenedChest", totalOpenedChest);
        myFile.Add("totalEnemyKilled", totalEnemyKilled);
    
        myFile.Save();
    }
    
    public void LoadData()
    {
        if (myFile.Load())
        {
            totalOpenedChest = myFile.GetInt("totalOpenedChest");
            totalEnemyKilled = myFile.GetInt("totalEnemyKilled");
        }
    }
}

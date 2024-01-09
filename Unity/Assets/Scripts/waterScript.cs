using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class waterScript : MonoBehaviour
{

    
    void Start()
    {
        
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Kaybettiniz");
            SceneManager.LoadScene("GameOverScreen");
        }

    }
    
    
}
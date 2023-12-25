using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chests : MonoBehaviour
{
 
    private void OnCollisionEnter2D(Collision2D collision) { 
        
        if (collision.gameObject.CompareTag("Player")) // Karakter sandıktan ayrıldığında
        {
            SceneManager.LoadScene("QuestionScreen");
            // Time.timeScale = 1f; // Oyun zamanını tekrar başlat (isteğe bağlı)
            // İsteğe bağlı diğer işlemler
        }
    }
}
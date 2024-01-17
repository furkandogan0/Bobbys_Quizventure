using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chests : MonoBehaviour
{
    Animator chestAnimator;
    [SerializeField] private SceneAsset scene;
    [SerializeField] private AudioSource ChestEffect;


    void Start()
    {
        chestAnimator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision) { 
        
        if (collision.gameObject.CompareTag("Player"))
        {
            chestAnimator.SetTrigger("open");
            ChestEffect.Play();
            
            Invoke("sahne",0.8f);
            // Time.timeScale = 1f; // Oyun zamanını tekrar başlat (isteğe bağlı)
            // İsteğe bağlı diğer işlemler
        }
    }

    private void sahne()
    {
        SceneManager.LoadScene(scene.name);
    }
}
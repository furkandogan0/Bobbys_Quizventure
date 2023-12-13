using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chests : MonoBehaviour
{
    public GameObject farkliEkran;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            farkliEkran.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            farkliEkran.SetActive(false);
        }
    }
}

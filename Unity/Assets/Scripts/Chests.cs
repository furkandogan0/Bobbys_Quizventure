using UnityEngine;

public class Chests : MonoBehaviour
{
    public GameObject ekran;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Karakter sandığa temas ettiğinde
        {
            ekran.SetActive(true); // Ekranı etkinleştir
            Time.timeScale = 0f; // Oyun zamanını durdur (isteğe bağlı)
            // İsteğe bağlı diğer işlemler
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Karakter sandıktan ayrıldığında
        {
            ekran.SetActive(false); // Ekranı devre dışı bırak
            Time.timeScale = 1f; // Oyun zamanını tekrar başlat (isteğe bağlı)
            // İsteğe bağlı diğer işlemler
        }
    }
}
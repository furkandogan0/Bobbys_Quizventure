using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class CameraMAnager : MonoBehaviour
//{

//    public Transform target;
//    public float cameraSpeed;
//    public float startOffset;
//    // Start is called before the first frame update
//    void Start()
//    {
//        {
//            float startX = target.position.x + startOffset;
//            transform.position = new Vector3(startX, transform.position.y, transform.position.z);
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
//    }
//}

//public class CameraManager : MonoBehaviour
//{
//    public Transform target;
//    public float cameraSpeed;
//    public float rightLimit; // Sa� s�n�r

//    void Update()
//    {
//        float targetX = target.position.x;
//        float cameraX = transform.position.x;

//        if (targetX > cameraX)
//        {
//            float newX = Mathf.Lerp(cameraX, targetX, cameraSpeed * Time.deltaTime);
//            transform.position = new Vector3(newX, transform.position.y, transform.position.z);
//        }

//        // Karakter sa� s�n�rdan fazla hareket etmi�se kameray� hareket ettirme
//        if (target.position.x >= rightLimit)
//        {
//            transform.position = new Vector3(rightLimit, transform.position.y, transform.position.z);
//        }
//    }
//}


public class CameraManager : MonoBehaviour
{
    public Transform target;
    public float cameraSpeed;
    public float maxXPosition; // Karakterin maksimum x pozisyonu

    private bool isFollowing = false;

    void Update()
    {
        // Karakterin x pozisyonu, kamera takibini ba�lat�r
        if (!isFollowing && target.position.x <= transform.position.x)
        {
            isFollowing = true;
        }

        if (isFollowing)
        {
            // Kamera takibi ba�lad�ysa ve karakter x pozisyonu s�n�ra ula�mad�ysa takip devam eder
            if (target.position.x >= maxXPosition)
            {
                transform.position = new Vector3(target.position.x, transform.position.y, transform.position.z);
            }
            else
            {
                // Karakter maksimum x pozisyonunu ge�erse kamera sabitlenir
                transform.position = new Vector3(maxXPosition, transform.position.y, transform.position.z);
            }
        }
    }
}



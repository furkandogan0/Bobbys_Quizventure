using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Ontrigger çalýþtý");
            GameManager.instance.SetCheckpoint(transform.position);
        }


    }
}

//using UnityEngine;

//public class Checkpoint : MonoBehaviour
//{
//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Player"))
//        {
//            GameManager.instance.SetCheckpoint(other.transform.position);
//        }
//    }
//}

